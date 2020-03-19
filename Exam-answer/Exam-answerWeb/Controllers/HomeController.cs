using AutoMapper;
using DAL.Entities;
using Exam_answerWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System.Net;

namespace Exam_answerWeb.Controllers
{
    public class HomeController : EaControllerBase //EaControllerBase
    {
        public HomeController(ExamAnswerContext examAnswerContext,
            IHostingEnvironment env, IMapper mapper, IMemoryCache memoryCache, IConfiguration configuration) :
            base(examAnswerContext, env, mapper, memoryCache, configuration)
        {
        }

        public IActionResult Index()
        {
            BaseViewModel baseViewModel = new BaseViewModel()
            {
                PageBaseCanonicalUrl = pageBaseCanonicalUrl,
                PageH1 = "Exam-Answer",
                PageDescription = "Community powered free exam questions with answers and explanations.",    
                PageTitle = "Exam-Answer",
                PageCanonicalUrl = pageBaseCanonicalUrl,
            };

            return View(baseViewModel);
        }

        [Route("privacy")]
        public IActionResult Privacy()
        {
            BaseViewModel baseViewModel = new BaseViewModel()
            {
                PageCanonicalUrl = $"{pageBaseCanonicalUrl}/contact",
                PageBaseCanonicalUrl = pageBaseCanonicalUrl,
                PageH1 = "Privacy",
                PageDescription = "Please read our privacy policy.",
                PageTitle = "Privacy | Exam-Answer",
            };

            return View(baseViewModel);
        }

        [Route("contact")]
        public IActionResult Contact()
        {
            BaseViewModel baseViewModel = new BaseViewModel()
            {
                PageCanonicalUrl = $"{pageBaseCanonicalUrl}/contact",
                PageBaseCanonicalUrl = pageBaseCanonicalUrl,
                PageH1 = "Contact Exam-Answer",
                PageDescription = "Contact us via email or our Facebook page.",
                PageTitle = "Contact | Exam-Answer",
            };

            return View(baseViewModel);
        }

        [Route("about")]
        public IActionResult About()
        {
            BaseViewModel baseViewModel = new BaseViewModel()
            {
                PageCanonicalUrl = $"{pageBaseCanonicalUrl}/contact",
                PageBaseCanonicalUrl = pageBaseCanonicalUrl,
                PageH1 = "About Exam-Answer",
                PageDescription = "Our aim is to provide accurate, up to date exam questions of popular IT exams. Not only that, but we search the Internet to provide an information to our readers why an answer of a question is right or wrong.",
                PageTitle = "About | Exam-Answer",
            };

            return View(baseViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Exception()
        {
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