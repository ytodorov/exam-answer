using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Exam_answerWeb.Infrastructure;
using Exam_answerWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Exam_AnswerWeb.Controllers
{
    [Route("salesforce/crt-251")]
    public class SalesforceController : Controller
    {
        private const string folderName = "crt-251";

        private IHostingEnvironment env;

        public SalesforceController(IHostingEnvironment env)
        {
            this.env = env;
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
        public IActionResult QuestionGeneric(string id)
        {           
            ViewData["title"] = $"Exam CRT-251: Question {id}";
            ViewData["id"] = id;

            ViewData["exam"] = "CRT-251";

            var cd = Environment.CurrentDirectory;

            if (int.TryParse(id, out int intId))
            {
                ViewData["basePath"] = "salesforce/crt-251/question";
                if (intId > 1)
                {
                    ViewData["prev"] = intId - 1;
                }
                if (intId < 152)
                {
                    ViewData["next"] = intId + 1;
                }
                ViewData["current"] = intId;
                ViewData["max"] = 71;
            }
            QuestionViewModel questionViewModel = new QuestionViewModel()
            {
                Id = id,
                H1OpenTag = "<h1>",
                H1CloseTag = "</h1>",
                H2OpenTag = "<h2>",
                H2CloseTag = "</h2>",

            };

            int fileSystemId = 0;

            string filePath = string.Empty;

            if (intId < 30)
            {
                fileSystemId = intId;
                filePath = $"{folderName}/question1_{id}";
            }
            else if (intId >= 30 && intId <= 61)
            {
                int newId = intId - 29;
                filePath = $"{folderName}/question2_{newId}";
            }
            else if (intId >= 62)
            {
                int newId = intId - 61;
                filePath = $"{folderName}/question3_{newId}";
            }
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

                StringBuilder descriptionLessThan320 = new StringBuilder();

                foreach (var sent in sentences)
                {
                    if (descriptionLessThan320.Length + sent.Length < 320)
                    {
                        descriptionLessThan320.Append(sent);
                    }
                    else
                    {
                        break;
                    }
                }

                description = descriptionLessThan320.ToString();

                ViewData["description"] = description;


            }


            return View(filePath, questionViewModel);
        }
    }
}