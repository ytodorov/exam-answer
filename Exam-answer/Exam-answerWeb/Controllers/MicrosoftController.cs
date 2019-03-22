using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return View($"{folderName}/index");
        }

        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
        [Route("question{id}")]
        public IActionResult QuestionGeneric(string id)
        {

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
                ViewData["max"] = 29;
            }
            return View($"{folderName}/question{id}");
        }
    }
}