using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exam_AnswerWeb.Controllers
{   
    [Route("microsoft/az-100/implement-and-manage-storage")]
    public class MicrosoftController : Controller
    {
        private const string folderName = "az-100/implement-and-manage-storage";

        [Route("question1")]
        public IActionResult Question1()
        {
            return View($"{folderName}/question1");
        }

        [Route("question2")]
        public IActionResult Question2()
        {
            return View($"{folderName}/question2");
        }
    }
}