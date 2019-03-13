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
        private const string folderName = "az-100/implement-and-manage-storage";

        [Route("question{id}")]
        public IActionResult QuestionGeneric(string id)
        {
            return View($"{folderName}/question{id}");
        }

        //[Route("question1")]
        //public IActionResult Question1()
        //{
        //    return View($"{folderName}/question1");
        //}

        //[Route("question2")]
        //public IActionResult Question2()
        //{
        //    return View($"{folderName}/question2");
        //}

        //[Route("question3")]
        //public IActionResult Question3()
        //{
        //    return View($"{folderName}/question3");
        //}

        //[Route("question4")]
        //public IActionResult Question4()
        //{
        //    return View($"{folderName}/question4");
        //}

        //[Route("question6")]
        //public IActionResult Question6()
        //{
        //    return View($"{folderName}/question6");
        //}

        //[Route("question8")]
        //public IActionResult Question8()
        //{
        //    return View($"{folderName}/question8");
        //}

        //[Route("question11")]
        //public IActionResult Question11()
        //{
        //    return View($"{folderName}/question11");
        //}
        //[Route("question12")]
        //public IActionResult Question12()
        //{
        //    return View($"{folderName}/question12");
        //}

        //[Route("question13")]
        //public IActionResult Question13()
        //{
        //    return View($"{folderName}/question13");
        //}

        //[Route("question14")]
        //public IActionResult Question14()
        //{
        //    return View($"{folderName}/question14");
        //}

        //[Route("question16")]
        //public IActionResult Question16()
        //{
        //    return View($"{folderName}/question16");
        //}
    }
}