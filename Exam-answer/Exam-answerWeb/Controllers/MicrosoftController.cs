using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Exam_answerWeb.Infrastructure;
using Exam_answerWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Exam_AnswerWeb.Controllers
{
    [Route("microsoft/az-100")]
    public class MicrosoftController : Controller
    {
        private const string folderName = "az-100";

        private IHostingEnvironment env;

        public MicrosoftController(IHostingEnvironment env)
        {
            this.env = env;
        }

        [Route("")]
        public IActionResult Index()
        {
            ViewData["title"] = $"Exam AZ-100 - ";
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
            ViewData["title"] = $"Exam AZ-100: Question {id} - ";
            ViewData["id"] = id;

            ViewData["exam"] = "AZ-100";

            var cd = Environment.CurrentDirectory;

            if (int.TryParse(id, out int intId))
            {
                if (intId > 1)
                {
                    ViewData["prev"] = intId - 1;
                }
                if (intId < 152)
                {
                    ViewData["next"] = intId + 1;
                }
                ViewData["current"] = intId;
                ViewData["max"] = 61;
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
                //return View($"{folderName}/question1_{id}", questionViewModel);
            }
            else
            {
                int newId = intId - 29;
                filePath = $"{folderName}/question2_{newId}";
                //return View($"{folderName}/question2_{newId}", questionViewModel);
            }

            string version = "Release";
#if DEBUG
            version = "Debug";
#endif
            string path = Path.Combine(env.ContentRootPath, "bin", version, @"netcoreapp2.2\Views\microsoft\az-100");
            string[] files = Directory.GetFiles(path);

            string theFile = files.FirstOrDefault(f => f.EndsWith($"{filePath}.cshtml".Replace("/", "\\")));
            if (!string.IsNullOrEmpty(theFile))
            {
                string fileContent = System.IO.File.ReadAllText(theFile);
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
                    .Replace("@Html.Raw(Model.H1OpenTag)", string.Empty)
                    .Replace("@Html.Raw(Model.H1CloseTag)", string.Empty)
                    .Replace("@Html.Raw(Model.H2OpenTag)", string.Empty)
                    .Replace("@Html.Raw(Model.H2CloseTag)", string.Empty)
                    .Replace(Environment.NewLine, string.Empty);

                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex("[ ]{2,}", options);
                description = regex.Replace(description, " ");
                description = description.Trim();

                ViewData["description"] = description;


            }


            return View(filePath, questionViewModel);
        }
    }
}