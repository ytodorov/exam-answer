using AutoMapper;
using DAL.Entities;
using Exam_answerWeb.Infrastructure;
using Exam_answerWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Exam_answerWeb.Controllers
{
    public class EaControllerBase : Controller
    {
        protected ExamAnswerContext examAnswerContext;
        protected readonly IHostingEnvironment env;

        protected readonly IMapper mapper;

        public EaControllerBase(ExamAnswerContext examAnswerContext, IHostingEnvironment env, IMapper mapper)
        {
            this.examAnswerContext = examAnswerContext;
            this.env = env;
            this.mapper = mapper;           
        }

        [Route("question{id}")]
        //[ResponseCache(Duration = 300, Location = ResponseCacheLocation.Any)]
        [OutputCache(Duration = 600)]
        public virtual IActionResult QuestionGeneric(string id)
        {
            List<string> segments = Request.Path.Value.Split("/", StringSplitOptions.RemoveEmptyEntries).ToList();
            string provider = segments[0];
            string examCode = segments[1];
            string questionId = segments[2].ToLowerInvariant().Replace("question", string.Empty);

            IActionResult res = QuestionGenericInternal(provider, examCode, questionId);

            return res;
        }

        [NonAction]
        protected IActionResult QuestionGenericInternal(string provider, string examCode, string id)
        {
            ExamEntity examEntity = DataGenerator.AllExames
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
            string url = HttpUtility.JavaScriptStringEncode($"https://www.exam-answer.com/salesforce/crt-251/question{id}");

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

            sbAcceptedAnswer.Append($@"{{
        ""@type"": ""Answer"",
        ""author"": ""{author}"",
        ""upvoteCount"": ""{upvoteCount}"",
        ""url"": ""{url}"",
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
        ""url"": ""{url}"",
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
                sbQuestionText.Append(c.Text);
            }
            string test =  HttpUtility.JavaScriptStringEncode("\"test\"");
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
  ""url"": ""{url}"",
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
                return View("Question", theQuestion);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
