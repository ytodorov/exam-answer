using AutoMapper;
using DAL.Entities;
using Exam_answerWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [NonAction]
        protected IActionResult QuestionGeneric(string provider, string examCode, string id)
        {
            ExamEntity examEntity = examAnswerContext.Exams
                .Where(e => e.Provider.Equals(provider, StringComparison.InvariantCultureIgnoreCase) &&
                    e.Code.Equals(examCode, StringComparison.InvariantCultureIgnoreCase))

                .Include(e => e.Questions)
                .ThenInclude(q => q.Contents)

                .Include(e => e.Questions)
                .ThenInclude(q => q.Answers)

                .Include(e => e.Questions)
                .ThenInclude(q => q.Explanations)

                .Include(e => e.Questions)
                .ThenInclude(q => q.References)

                .AsNoTracking()

                .FirstOrDefault();

            var examViewModel = mapper.Map<ExamViewModel>(examEntity);

            string title = $"Exam {examViewModel.Code}: Question {id}";
            ViewData["title"] = title;

            ViewData["id"] = id;

            var cd = Environment.CurrentDirectory;

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

            var questionVM = examViewModel.Questions[intId - 1];

            ViewData["description"] = questionVM.Contents?.FirstOrDefault()?.Text;

            StringBuilder microdataJson = new StringBuilder();

            DateTime dateCreatedDate = new DateTime(2019, 2, 17);
            string dateCreated = "2019-03-27T15:01Z";

            ViewData["hasMicrodata"] = true;

            string author = "exam-answer.com";

            string upvoteCount = "0";
            string url = $"https://www.exam-answer.com/salesforce/crt-251/question{id}";

            var acceptedAnswers = questionVM.Answers.Where(a => a.IsCorrect == true).ToList();
            var suggestedAnswers = questionVM.Answers.Where(a => a.IsCorrect != true).ToList();

            StringBuilder sbAcceptedAnswer = new StringBuilder();
            StringBuilder sbSuggestedAnswer = new StringBuilder();

            sbAcceptedAnswer.AppendLine("[");
            foreach (var aa in acceptedAnswers)
            {
                sbAcceptedAnswer.Append($@"{{
        ""@type"": ""Answer"",
        ""author"": ""{author}"",
        ""upvoteCount"": ""{upvoteCount}"",
        ""url"": ""{url}"",
        ""dateCreated"": ""{dateCreated}"",
        ""text"": ""{aa.Text}""
                }}");
                if (acceptedAnswers.IndexOf(aa) != acceptedAnswers.Count - 1)
                {
                    sbAcceptedAnswer.Append(",");
                }
            }
            sbAcceptedAnswer.AppendLine("]");

            sbSuggestedAnswer.AppendLine("[");
            foreach (var aa in suggestedAnswers)
            {
                sbSuggestedAnswer.Append($@"{{
        ""@type"": ""Answer"",
        ""author"": ""{author}"",
        ""upvoteCount"": ""{upvoteCount}"",
        ""url"": ""{url}"",
        ""dateCreated"": ""{dateCreated}"",
        ""text"": ""{aa.Text}""
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

            foreach (var c in questionVM.Contents)
            {
                sbQuestionText.Append(c.Text);
            }

            string questionText = sbQuestionText.ToString();

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
  ""dateCreated"": ""{dateCreatedDate}"",
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
                var theQuestion = examViewModel.Questions[intId - 1];
                return View("Question", theQuestion);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
