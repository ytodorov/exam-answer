using AutoMapper;
using DAL.Entities;
using Exam_answerWeb.Extensions;
using Exam_answerWeb.Infrastructure;
using Exam_answerWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Exam_answerWeb.Controllers
{
    public class EaControllerBase : Controller
    {
        protected ExamAnswerContext examAnswerContext;
        protected readonly IHostingEnvironment env;
        protected readonly IMapper mapper;
        protected readonly IConfiguration configuration;
        private IMemoryCache cache;

        protected string pageBaseCanonicalUrl = string.Empty;

        public EaControllerBase(
            ExamAnswerContext examAnswerContext,
            IHostingEnvironment env,
            IMapper mapper,
            IMemoryCache memoryCache,
            IConfiguration configuration
            )
        {
            this.examAnswerContext = examAnswerContext;
            this.env = env;
            this.mapper = mapper;
            cache = memoryCache;
            this.configuration = configuration;

            pageBaseCanonicalUrl = configuration.GetValue(typeof(string), "PageBaseCanonicalUrl")?.ToString();
        }

        public override ViewResult View(string viewName, object model)
        {
            return base.View(viewName, model);
        }

        [Route("question{id}")]
        public virtual IActionResult QuestionGeneric(string id)
        {
            List<string> segments = Request.Path.Value.Split("/", StringSplitOptions.RemoveEmptyEntries).ToList();
            string provider = segments[0];
            string examCode = segments[1];
            string questionId = segments[2].ToLowerInvariant().Replace("question", string.Empty);

            IActionResult res = QuestionGenericInternal(provider, examCode, questionId);

            ViewData["canonicalUrl"] = "https://www.exam-answer.com" + HttpContext.Request.Path.ToString().TrimEnd('/');

            return res;
        }

        [NonAction]
        protected IActionResult QuestionGenericInternal(string provider, string examCode, string id)
        {
            ExamEntity examEntity = DataGenerator.AllExams
                .Where(e => e.Provider.Equals(provider, StringComparison.InvariantCultureIgnoreCase) &&
                    e.Code.Equals(examCode, StringComparison.InvariantCultureIgnoreCase))

                .FirstOrDefault();

            ExamViewModel examViewModel = mapper.Map<ExamViewModel>(examEntity);

            string title = $"Exam {examViewModel.Code}: Question {id}";
            ViewData["title"] = title;

            ViewData["id"] = id;
            if (examViewModel.Code?.Equals("CRT-251", StringComparison.InvariantCultureIgnoreCase) == true)
            {
                ViewData["imageUrl"] = "images/salesforce/crt-251.png";
                ViewData["imageAlt"] = $"{examViewModel.Provider}, {examViewModel.Code}: {examViewModel.Name}";
            }
            else if (examViewModel.Code?.Equals("AZ-900", StringComparison.InvariantCultureIgnoreCase) == true)
            {
                ViewData["imageUrl"] = "images/az-900.png";
                ViewData["imageAlt"] = $"{examViewModel.Provider}, {examViewModel.Code}: {examViewModel.Name}";
            }
            else if (examViewModel.Code?.Equals("AZ-100", StringComparison.InvariantCultureIgnoreCase) == true)
            {
                ViewData["imageUrl"] = "images/az-100.png";
                ViewData["imageAlt"] = $"{examViewModel.Provider}, {examViewModel.Code}: {examViewModel.Name}";
            }

            string cd = Environment.CurrentDirectory;

            if (int.TryParse(id, out int intId))
            {
                ViewData["basePath"] = $"{examViewModel.Provider.ToLowerInvariant()}/{examViewModel.Code.ToLowerInvariant()}/question";
                ViewData["prev"] = intId - 1;
                ViewData["next"] = intId + 1;
                ViewData["current"] = intId;
                ViewData["max"] = examViewModel.Questions.Count;
            }

            if (intId > examViewModel.Questions.Count || intId == 0)
            {
                return NotFound();
            }

            QuestionViewModel questionVM = examViewModel.Questions[intId - 1];

            ViewData["description"] = questionVM.Contents?.FirstOrDefault()?.Text;

            StringBuilder microdataJson = new StringBuilder();

            string dateCreated = "2019-03-27T15:01Z";

            ViewData["hasMicrodata"] = true;

            string author = HttpUtility.JavaScriptStringEncode("exam-answer.com");

            string upvoteCount = HttpUtility.JavaScriptStringEncode("0");
            string canonicalUrl = $"https://www.exam-answer.com/{examViewModel.Provider?.ToLowerInvariant()}/{examViewModel.Code?.ToLowerInvariant()}/question{id}";
            string canonicalUrlEncoded = HttpUtility.JavaScriptStringEncode(canonicalUrl);

            List<AnswerViewModel> acceptedAnswers = questionVM.Answers.Where(a => a.IsCorrect == true).ToList();
            List<AnswerViewModel> suggestedAnswers = questionVM.Answers.Where(a => a.IsCorrect != true).ToList();

            StringBuilder sbAcceptedAnswer = new StringBuilder();
            StringBuilder sbSuggestedAnswer = new StringBuilder();

            sbAcceptedAnswer.AppendLine("[");

            string allAnswers = string.Empty;
            foreach (AnswerViewModel aa in acceptedAnswers)
            {
                allAnswers += $"{aa.Text} ";
            }

            allAnswers = allAnswers.Trim();

            if (string.IsNullOrWhiteSpace(allAnswers))
            {
                allAnswers = questionVM.AcceptedAnswer;
            }

            allAnswers = allAnswers.Replace("\\", "\\\\").Replace("\"", "\\\"");

            sbAcceptedAnswer.Append($@"{{
        ""@type"": ""Answer"",
        ""author"": ""{author}"",
        ""upvoteCount"": ""{upvoteCount}"",
        ""url"": ""{canonicalUrlEncoded}"",
        ""dateCreated"": ""{dateCreated}"",
        ""text"": ""{allAnswers}""
                }}");
            //if (acceptedAnswers.IndexOf(aa) != acceptedAnswers.Count - 1)
            //{
            //    sbAcceptedAnswer.Append(",");
            //}

            //    foreach (var aa in acceptedAnswers)
            //    {
            //        string text = HttpUtility.JavaScriptStringEncode(aa.Text);

            //        sbAcceptedAnswer.Append($@"{{
            //""@type"": ""Answer"",
            //""author"": ""{author}"",
            //""upvoteCount"": ""{upvoteCount}"",
            //""url"": ""{url}"",
            //""dateCreated"": ""{dateCreated}"",
            //""text"": ""{text}""
            //        }}");
            //        if (acceptedAnswers.IndexOf(aa) != acceptedAnswers.Count - 1)
            //        {
            //            sbAcceptedAnswer.Append(",");
            //        }

            //        break;
            //    }
            sbAcceptedAnswer.AppendLine("]");

            sbSuggestedAnswer.AppendLine("[");
            foreach (AnswerViewModel aa in suggestedAnswers)
            {
                string text = HttpUtility.JavaScriptStringEncode(aa.Text);

                sbSuggestedAnswer.Append($@"{{
        ""@type"": ""Answer"",
        ""author"": ""{author}"",
        ""upvoteCount"": ""{upvoteCount}"",
        ""url"": ""{canonicalUrlEncoded}"",
        ""dateCreated"": ""{dateCreated}"",
        ""text"": ""{text}""
                }}");
                if (suggestedAnswers.IndexOf(aa) != suggestedAnswers.Count - 1)
                {
                    sbSuggestedAnswer.Append(",");
                }
            }
            sbSuggestedAnswer.AppendLine("]");

            string acceptedAnswer = sbAcceptedAnswer.ToString();
            string suggestedAnswer = sbSuggestedAnswer.ToString();

            StringBuilder sbQuestionText = new StringBuilder();

            foreach (ContentViewModel c in questionVM.Contents)
            {
                sbQuestionText.Append($"{c.Text} ");
            }
            string test = HttpUtility.JavaScriptStringEncode("\"test\"");
            string questionText = HttpUtility.JavaScriptStringEncode(sbQuestionText.ToString());

            // https://developers.google.com/search/docs/data-types/faqpage
            microdataJson.Append(
$@"
<script type=""application/ld+json"">
{{
  ""@context"": ""http://schema.org"",
  ""@type"": ""FAQPage"",
  ""mainEntity"": {{
  ""@type"": ""Question"",
  ""name"": ""{questionText}"",
  ""author"": ""{author}"",
  ""url"": ""{canonicalUrlEncoded}"",
  ""dateCreated"": ""{dateCreated}"",
  ""text"": ""{questionText}"",
  ""answerCount"": ""{questionVM.Answers.Count}"",
  ""acceptedAnswer"": {acceptedAnswer},
  ""suggestedAnswer"": {suggestedAnswer}
}}
}}
 </script>");

            string microdata = microdataJson.ToString();
            ViewData["microdata"] = microdata;

            if (intId <= examViewModel.Questions.Count)
            {
                QuestionViewModel theQuestion = examViewModel.Questions[intId - 1];
                QuestionEntity questionEntity = examEntity.Questions[intId - 1];

                theQuestion.PageBaseCanonicalUrl = pageBaseCanonicalUrl;
                theQuestion.PageMicrodata = microdata;
                theQuestion.PageTitle = title + " | Exam-Answer";

                // Page description should be max 160 chars.
                List<string> words = new List<string>();

                foreach (ContentEntity content in questionEntity.Contents)
                {
                    words.AddRange(content.Text.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
                }

                StringBuilder pageDescription = new StringBuilder();

                foreach (string w in words)
                {
                    if (pageDescription.Length + w.Length >= 160)
                    {
                        break;
                    }
                    else
                    {
                        pageDescription.Append($"{w} ");
                    }
                }

                theQuestion.PageDescription = pageDescription.ToString().Trim(); //questionEntity.ContentText;
                theQuestion.PageCanonicalUrl = canonicalUrl;
                theQuestion.PageMicrodata = microdata;
                ViewResult view = View("Question", theQuestion);

                //var htmlToCache = view.ToHtml(HttpContext);
                //bool isMobile = HttpContext.IsMobileBrowser();

                //cache.Set<string>(HttpContext.Request.Path.ToString() + "_IsMobile_" + isMobile.ToString(), htmlToCache);

                return view;
            }
            else
            {
                return NotFound();
            }
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            ViewResult viewResult = context.Result as ViewResult;

            if (viewResult != null)
            {
                string htmlToCache = viewResult.ToHtml(HttpContext);
                bool isMobile = HttpContext.IsMobileBrowser();
                int statusCode = HttpContext.Response.StatusCode;
                if (statusCode == StatusCodes.Status200OK)
                {
                    cache.Set<string>(HttpContext.Request.Path.ToString() + "_IsMobile_" + isMobile.ToString(), htmlToCache);
                }
            }
            base.OnActionExecuted(context);
        }

        
    }
}