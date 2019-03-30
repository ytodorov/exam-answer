using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_answerWeb.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Exam_AnswerWeb.Controllers
{   
    [Route("microsoft/az-100")]
    public class MicrosoftController : Controller
    {
        private const string folderName = "az-100";

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
                
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
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
            if (intId < 30)
            {
                return View($"{folderName}/question1_{id}");
            }
            else
            {
                int newId = intId - 29;
                return View($"{folderName}/question2_{newId}");
            }
        }
    }
}