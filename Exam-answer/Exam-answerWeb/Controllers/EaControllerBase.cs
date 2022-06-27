﻿using AutoMapper;
using DAL.Entities;
using Exam_answerWeb.Extensions;
using Exam_answerWeb.Infrastructure;
using Exam_answerWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace Exam_answerWeb.Controllers
{
    public class EaControllerBase : Controller
    {
        protected ExamAnswerContext examAnswerContext;
        protected readonly IMapper mapper;
        protected readonly IConfiguration configuration;
        private readonly IMemoryCache cache;

        protected string pageBaseCanonicalUrl = string.Empty;

        public EaControllerBase(IServiceProvider serviceProvider)
        {
            this.examAnswerContext = serviceProvider.GetService<ExamAnswerContext>();
            this.mapper = serviceProvider.GetService<IMapper>();
            cache = serviceProvider.GetService<IMemoryCache>();
            this.configuration = serviceProvider.GetService<IConfiguration>();

            pageBaseCanonicalUrl = configuration.GetValue(typeof(string), "PageBaseCanonicalUrl")?.ToString();
        }

        public override ViewResult View(string viewName, object model)
        {
            return base.View(viewName, model);
        }

        protected ExamViewModel GetExamViewModelFromHttpContext()
        {
            // HttpContext.Request.Path = /salesforce/salesforce-certified-field-service-lightning-consultant

            var parts = HttpContext.Request.Path.ToString().Split('/', StringSplitOptions.RemoveEmptyEntries);
            var provider = parts[0];
            var code = parts[1];
            var exams = DataGenerator.AllExams;
            ExamEntity examEntity = exams
               .Where(e => e.Provider.Equals(provider, StringComparison.InvariantCultureIgnoreCase) &&
                   e.Code.Equals(code, StringComparison.InvariantCultureIgnoreCase))

               //.Include(e => e.Questions)
               //.ThenInclude(q => q.Contents)

               //.Include(e => e.Questions)
               //.ThenInclude(q => q.Answers)

               //.Include(e => e.Questions)
               //.ThenInclude(q => q.Explanations)

               //.Include(e => e.Questions)
               //.ThenInclude(q => q.References)

               //.AsNoTracking()

               .FirstOrDefault();

            ExamViewModel examViewModel = mapper.Map<ExamViewModel>(examEntity);

            examViewModel.PageBaseCanonicalUrl = pageBaseCanonicalUrl;

            examViewModel.PageCanonicalUrl = $"{pageBaseCanonicalUrl}/{provider}/{code}";

            examViewModel.PageMicrodata = $@"<script type=""application/ld+json"">
    {{
      ""@context"": ""http://schema.org"",
      ""@type"": ""Webpage"",
      ""url"": ""{examViewModel.PageCanonicalUrl}"",
      ""name"": ""{examViewModel.Title}"",
      ""headline"": ""{examViewModel.Title}"",
      ""description"": ""{examViewModel.Description}"",
      ""mainEntityOfPage"": {{
        ""@type"": ""WebPage"",
        ""@id"": ""{examViewModel.PageCanonicalUrl}""
      }},
      ""publisher"": {{
        ""@type"": ""Organization"",
        ""name"": ""{examViewModel.PageCanonicalUrl}"",
        ""logo"": {{
          ""url"": ""{examViewModel.PageCanonicalUrl}/android-chrome-512x512.png"",
          ""width"": 512,
          ""height"": 512,
          ""@type"": ""ImageObject""
        }}
      }},
      ""image"": {{
        ""@type"": ""ImageObject"",
        ""url"": ""{examViewModel.PageCanonicalUrl}/android-chrome-512x512.png"",
        ""width"": 512,
        ""height"": 512
      }}
    }}";

            return examViewModel;

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

            string dateCreated = "2020-03-27T15:01Z";

            ViewData["hasMicrodata"] = true;

            string author = HttpUtility.JavaScriptStringEncode("exam-answer.com");

            string upvoteCount = HttpUtility.JavaScriptStringEncode("0");
            string canonicalUrl = $"https://www.exam-answer.com/{examViewModel.Provider?.ToLowerInvariant()}/{examViewModel.Code?.ToLowerInvariant()}/question{id}";
            string canonicalUrlEncoded = HttpUtility.JavaScriptStringEncode(canonicalUrl);

            List<AnswerViewModel> acceptedAnswers = questionVM.Answers.Where(a => a.IsCorrect == true).ToList();
            
            List<AnswerViewModel> suggestedAnswers = questionVM.Answers.Where(a => a.IsCorrect != true).ToList();

            if (questionVM.QuestionType == QuestionType.DropDown)
            {
                acceptedAnswers = new List<AnswerViewModel>();
                suggestedAnswers = new List<AnswerViewModel>();
                foreach (var ans in questionVM.Answers)
                {
                    var values = ans.Text.Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();
                    var titleOfDdlAnswer = values.FirstOrDefault();

                    values = values.Skip(1).ToList();

                    List<string> wrongAnswers = values.Where(v => !v.Trim().EndsWith("*")).ToList().Select(s => s.Replace("*", string.Empty).Trim()).ToList();
                    List<string> correctAnswers = values.Where(v => v.Trim().EndsWith("*")).ToList().Select(s => s.Replace("*", string.Empty).Trim()).ToList();

                    acceptedAnswers.Add(new AnswerViewModel() { Text = $"{titleOfDdlAnswer}: {string.Join(", ", correctAnswers)}" });
                    suggestedAnswers.Add(new AnswerViewModel() { Text = $"{titleOfDdlAnswer}: {string.Join(", ", wrongAnswers)}" });
                }
            }

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

            if (allAnswers != null) // TO DO for DropDown
            {
                allAnswers = allAnswers.Replace("\\", "\\\\").Replace("\"", "\\\"");
            }
            else
            {
                allAnswers = string.Empty; // TO DO for DropDown
            }

            sbAcceptedAnswer.Append($@"{{
        ""@type"": ""Answer"",
        ""author"": ""{author}"",
        ""upvoteCount"": ""{upvoteCount}"",
        ""url"": ""{canonicalUrlEncoded}"",
        ""dateCreated"": ""{dateCreated}"",
        ""text"": ""{allAnswers}""
                }}");

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

                foreach (AnswerEntity answer in questionEntity.Answers)
                {
                    words.AddRange(answer.Text.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
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

                theQuestion.PageDescription = pageDescription.ToString().Trim();
                theQuestion.PageCanonicalUrl = canonicalUrl;
                theQuestion.PageMicrodata = microdata;
                ViewResult view = View("Question", theQuestion);

                return view;
            }
            else
            {
                return NotFound();
            }
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Result is ViewResult viewResult)
            {
                string htmlToCache = viewResult.ToHtml(HttpContext);
                bool isMobile = HttpContext.IsMobileBrowser();
                int statusCode = HttpContext.Response.StatusCode;
                if (statusCode == StatusCodes.Status200OK)
                {
                    // do not cache dynamically calculated data - as real exam with random questions
                    if (!HttpContext.Request.Path.ToString().Contains("test", StringComparison.InvariantCultureIgnoreCase))
                    {
                        cache.Set<string>(HttpContext.Request.Path.ToString() + "_IsMobile_" + isMobile.ToString(), htmlToCache);

                        // convert string to stream
                        byte[] byteArray = Encoding.ASCII.GetBytes(htmlToCache);

                        using (MemoryStream fs = new MemoryStream(byteArray))
                        using (var ms = new MemoryStream())
                        {
                            using (var bs = new BrotliSharpLib.BrotliStream(ms, System.IO.Compression.CompressionMode.Compress))
                            {
                                bs.SetQuality(11);
                                fs.Position = 0;
                                fs.CopyTo(bs);

                                bs.Dispose();
                                byte[] compressed = ms.ToArray();

                                cache.Set<byte[]>(HttpContext.Request.Path.ToString() + "_IsMobile_" + isMobile.ToString() + "compressedBr", compressed);
                            }
                        }
                    }
                }
            }
            base.OnActionExecuted(context);
        }

        
    }
}