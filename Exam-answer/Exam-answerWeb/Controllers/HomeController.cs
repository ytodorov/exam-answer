using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exam_answerWeb.Models;
using System.Net;

namespace Exam_answerWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
         
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Exception()
        {
            var c = ControllerContext;
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            return View("GenericError");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(string id)
        {
            if (id == "404")
            {
                HttpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
                return View("NotFound");
            }
            else if (id == "500")
            {
                HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

            return View("GenericError");
        }

        [Route("/.well-known/pki-validation/FC9F18C3634865886ED5E56EFF25A21F.txt")]
        public string Cert()
        {
            return "72D484190ADB24E5CA29B64BAFC2BDC32B279758A6E70A2589AE3610CF2AB79F comodoca.com 5c941e16c088d";
        }
    }
}
