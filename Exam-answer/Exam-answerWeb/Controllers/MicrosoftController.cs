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
using Microsoft.Extensions.Caching.Memory;

namespace Exam_AnswerWeb.Controllers
{
    [Route("microsoft/az-100")]
    public class MicrosoftController : EaControllerBase
    {
        private const string folderName = "az-100";

        public MicrosoftController(ExamAnswerContext examAnswerContext, IHostingEnvironment env, IMapper mapper, IMemoryCache memoryCache) :
            base(examAnswerContext, env, mapper, memoryCache)
        {
        }

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
        [ResponseCache(Duration = 300, Location = ResponseCacheLocation.Any)]
        public override IActionResult QuestionGeneric(string id)
        {
            if (int.TryParse(id, out int intId))
            {
                ViewData["basePath"] = "microsoft/az-100/question";
                ViewData["prev"] = intId - 1;
                ViewData["next"] = intId + 1;
                ViewData["current"] = intId;
                ViewData["max"] = 115;
            }

            if (intId > 0 && intId <= 15)
            {
                IActionResult res = QuestionGenericInternal("microsoft", "az-100", id);
                return res;
            }

            string title = $"Exam AZ-100: Question {id}";

            ViewData["title"] = title;
            ViewData["id"] = id;

            string cd = Environment.CurrentDirectory;

           
            QuestionOldViewModel questionViewModel = new QuestionOldViewModel()
            {
                Id = id,
                H1OpenTag = "<h1>",
                H1CloseTag = "</h1>",
                H2OpenTag = "<h2>",
                H2CloseTag = "</h2>",

            };

            string filePath = $"{folderName}/question{intId}";

            // Could not find a part of the path 'D:\home\site\wwwroot\bin\Release\netcoreapp2.2\Views\microsoft\az-100'.
            string path = Path.Combine(env.WebRootPath); //"bin", version, @"netcoreapp2.2\Views\microsoft\az-100");
            string[] files = Directory.GetFiles(path + @"\microsoft\az-100", "*.cshtml", SearchOption.AllDirectories);

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

                foreach (string sent in sentences)
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

                DateTime dateCreated = new DateTime(2019, 2, 17);
                string dateCreatedString = dateCreated.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");

                ViewData["hasMicrodata"] = true;

                microdataJson.Append(
$@"
<script type=""application/ld+json"">
{{  
  ""@context"": ""http://schema.org"",
  ""@type"": ""Question"",
  ""name"": ""{title}"",
  ""text"": ""{description}"",
  ""dateCreated"": ""{dateCreatedString}""
}}
 </script>");

                string microdata = microdataJson.ToString();
                ViewData["microdata"] = microdata;


            }

            return View(filePath, questionViewModel);
        }
    }
}