using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Entities;
using Exam_answerWeb.Controllers;
using Exam_answerWeb.Infrastructure;
using Exam_answerWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;


namespace Exam_AnswerWeb.Controllers
{
    [Route("salesforce/crt-251")]
    public class SalesforceController : BaseController
    {
        public SalesforceController(ExamAnswerContext examAnswerContext, IHostingEnvironment env, IMapper mapper) :
            base(examAnswerContext, env, mapper)
        {

        }

        private const string folderName = "crt-251";

        [Route("")]
        public IActionResult Index()
        {
            return View($"{folderName}/index");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }

        //[ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
        [Route("question{id}")]
        public IActionResult QuestionGeneric(string id)
        {
            ExamEntity examEntity = examAnswerContext.Exams
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
            var questionVM = examViewModel.Questions.FirstOrDefault();

            

            string title = $"Exam CRT-251: Question {id}";
            ViewData["title"] = title;

            ViewData["id"] = id;

            ViewData["exam"] = "CRT-251";

            var cd = Environment.CurrentDirectory;

            if (int.TryParse(id, out int intId))
            {
                ViewData["basePath"] = "salesforce/crt-251/question";
                ViewData["prev"] = intId - 1;
                ViewData["next"] = intId + 1;
                ViewData["current"] = intId;
                ViewData["max"] = 98;
            }

            //if (intId <= examViewModel.Questions.Count)
            //{
            //    var theQuestion = examViewModel.Questions[intId - 1];
            //    return View("Question", theQuestion);
            //}

            QuestionOldViewModel questionViewModel = new QuestionOldViewModel()
            {
                Id = id,
                H1OpenTag = "<h1>",
                H1CloseTag = "</h1>",
                H2OpenTag = "<h2>",
                H2CloseTag = "</h2>",

            };

            int fileSystemId = 0;

            string filePath = string.Empty;


            fileSystemId = intId;
            filePath = $"{folderName}/question{id}";

            // Could not find a part of the path 'D:\home\site\wwwroot\bin\Release\netcoreapp2.2\Views\microsoft\az-100'.
            string path = Path.Combine(env.WebRootPath); //"bin", version, @"netcoreapp2.2\Views\microsoft\az-100");
            string[] files = Directory.GetFiles(path + @"\salesforce\crt-251", "*.cshtml", SearchOption.AllDirectories);

            string theFile = files.FirstOrDefault(f => f.EndsWith($"{filePath}.cshtml".Replace("/", "\\")));
            if (!string.IsNullOrEmpty(theFile))
            {
                string fileContent = System.IO.File.ReadAllText(theFile);

                string[] lines = System.IO.File.ReadAllLines(theFile);
                lines = lines.Where(l => !l.Trim().StartsWith("@") && !l.Trim().StartsWith("&")).ToArray();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < lines.Length; i++)
                {
                    sb.Append(lines[i]);
                }

                fileContent = sb.ToString();


                int indexLiStart = fileContent.IndexOf("<li");
                int indexLiEnd = fileContent.IndexOf("</li>");
                int length = indexLiEnd - indexLiStart;

                string substring = fileContent.Substring(indexLiStart, length);

                string description = substring
                    .Replace("<li class=\"k-state-active\">", string.Empty)
                    .Replace("<span class=\"k-link k-state-selected\">Question @Model?.Id</span>", string.Empty)
                    .Replace("<div>", string.Empty)
                    .Replace("</div>", string.Empty)
                    .Replace("<p>", string.Empty)
                    .Replace("</p>", string.Empty)
                    .Replace("<br />", string.Empty)
                    .Replace("@Html.Raw(Model.H1OpenTag)", string.Empty)
                    .Replace("@Html.Raw(Model.H1CloseTag)", string.Empty)
                    .Replace("@Html.Raw(Model.H2OpenTag)", string.Empty)
                    .Replace("@Html.Raw(Model.H2CloseTag)", string.Empty)
                    .Replace(Environment.NewLine, string.Empty);

                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex("[ ]{2,}", options);
                description = regex.Replace(description, " ");
                description = description.Trim();

                string[] sentences = description.Split('.');

                StringBuilder descriptionLessThan250 = new StringBuilder();

                foreach (var sent in sentences)
                {
                    if (descriptionLessThan250.Length + sent.Length < 250)
                    {
                        descriptionLessThan250.Append(sent);
                    }
                    else
                    {
                        break;
                    }
                }

                //description = descriptionLessThan250.ToString();

                ViewData["description"] = descriptionLessThan250;

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

               

                microdataJson.Append(
$@"
<script type=""application/ld+json"">
{{  
  ""@context"": ""http://schema.org"",
  ""@type"": ""QAPage"",
  ""mainEntity"": {{
  ""@type"": ""Question"",
  ""name"": ""{title}"",
  ""author"": ""{author}"",
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
            }

            if (intId <= examViewModel.Questions.Count)
            {
                var theQuestion = examViewModel.Questions[intId - 1];
                return View("Question", theQuestion);
            }

            return View(filePath, questionViewModel);

        }
    }
}