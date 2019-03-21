using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exam_answerWeb.Models;

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
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("/.well-known/pki-validation/D67C33543D08AB8D948517B8C6FC8AB6.txt")]
        public string Cert()
        {
            return "C4EFB5C501298A5174718DC052BC2C7EBFF2038F2883504865F5B1A617013EA5 comodoca.com 5c93d4a8e2e04";
        }
    }
}
