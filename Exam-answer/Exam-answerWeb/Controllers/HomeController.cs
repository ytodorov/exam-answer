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
                PageDescription = "Community powered free exam questions with answers and explanations",
                PageTitle = "Exam-Answer",
                PageCanonicalUrl = pageBaseCanonicalUrl,
            };

            baseViewModel.PageMicrodata = $@"<script type=""application/ld+json"">
    {{
      ""@context"": ""http://schema.org"",
      ""@type"": ""Webpage"",
      ""url"": ""{baseViewModel.PageCanonicalUrl}"",
      ""name"": ""{baseViewModel.PageTitle}"",
      ""headline"": ""{baseViewModel.PageTitle}"",
      ""description"": ""{baseViewModel.PageDescription}"",
      ""mainEntityOfPage"": {{
        ""@type"": ""WebPage"",
        ""@id"": ""{baseViewModel.PageCanonicalUrl}""
      }},
      ""publisher"": {{
        ""@type"": ""Organization"",
        ""name"": ""{baseViewModel.PageCanonicalUrl}"",
        ""logo"": {{
          ""url"": ""{baseViewModel.PageCanonicalUrl}/android-chrome-512x512.png"",
          ""width"": 512,
          ""height"": 512,
          ""@type"": ""ImageObject""
        }}
      }},
      ""image"": {{
        ""@type"": ""ImageObject"",
        ""url"": ""{baseViewModel.PageCanonicalUrl}/android-chrome-512x512.png"",
        ""width"": 512,
        ""height"": 512
      }}
    }}";

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

            baseViewModel.PageMicrodata = $@"<script type=""application/ld+json"">
    {{
      ""@context"": ""http://schema.org"",
      ""@type"": ""Webpage"",
      ""url"": ""{baseViewModel.PageCanonicalUrl}"",
      ""name"": ""{baseViewModel.PageTitle}"",
      ""headline"": ""{baseViewModel.PageTitle}"",
      ""description"": ""{baseViewModel.PageDescription}"",
      ""mainEntityOfPage"": {{
        ""@type"": ""WebPage"",
        ""@id"": ""{baseViewModel.PageCanonicalUrl}""
      }},
      ""publisher"": {{
        ""@type"": ""Organization"",
        ""name"": ""{baseViewModel.PageCanonicalUrl}"",
        ""logo"": {{
          ""url"": ""{baseViewModel.PageCanonicalUrl}/android-chrome-512x512.png"",
          ""width"": 512,
          ""height"": 512,
          ""@type"": ""ImageObject""
        }}
      }},
      ""image"": {{
        ""@type"": ""ImageObject"",
        ""url"": ""{baseViewModel.PageCanonicalUrl}/android-chrome-512x512.png"",
        ""width"": 512,
        ""height"": 512
      }}
    }}";

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
            baseViewModel.PageMicrodata = $@"<script type=""application/ld+json"">
    {{
      ""@context"": ""http://schema.org"",
      ""@type"": ""Webpage"",
      ""url"": ""{baseViewModel.PageCanonicalUrl}"",
      ""name"": ""{baseViewModel.PageTitle}"",
      ""headline"": ""{baseViewModel.PageTitle}"",
      ""description"": ""{baseViewModel.PageDescription}"",
      ""mainEntityOfPage"": {{
        ""@type"": ""WebPage"",
        ""@id"": ""{baseViewModel.PageCanonicalUrl}""
      }},
      ""publisher"": {{
        ""@type"": ""Organization"",
        ""name"": ""{baseViewModel.PageCanonicalUrl}"",
        ""logo"": {{
          ""url"": ""{baseViewModel.PageCanonicalUrl}/android-chrome-512x512.png"",
          ""width"": 512,
          ""height"": 512,
          ""@type"": ""ImageObject""
        }}
      }},
      ""image"": {{
        ""@type"": ""ImageObject"",
        ""url"": ""{baseViewModel.PageCanonicalUrl}/android-chrome-512x512.png"",
        ""width"": 512,
        ""height"": 512
      }}
    }}";

            return View(baseViewModel);
        }
        [Route("trustlogo")]
        public IActionResult TrustLogo()
        {
            return View();
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

            baseViewModel.PageMicrodata = $@"<script type=""application/ld+json"">
    {{
      ""@context"": ""http://schema.org"",
      ""@type"": ""Webpage"",
      ""url"": ""{baseViewModel.PageCanonicalUrl}"",
      ""name"": ""{baseViewModel.PageTitle}"",
      ""headline"": ""{baseViewModel.PageTitle}"",
      ""description"": ""{baseViewModel.PageDescription}"",
      ""mainEntityOfPage"": {{
        ""@type"": ""WebPage"",
        ""@id"": ""{baseViewModel.PageCanonicalUrl}""
      }},
      ""publisher"": {{
        ""@type"": ""Organization"",
        ""name"": ""{baseViewModel.PageCanonicalUrl}"",
        ""logo"": {{
          ""url"": ""{baseViewModel.PageCanonicalUrl}/android-chrome-512x512.png"",
          ""width"": 512,
          ""height"": 512,
          ""@type"": ""ImageObject""
        }}
      }},
      ""image"": {{
        ""@type"": ""ImageObject"",
        ""url"": ""{baseViewModel.PageCanonicalUrl}/android-chrome-512x512.png"",
        ""width"": 512,
        ""height"": 512
      }}
    }}";

            return View(baseViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Exception()
        {
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            return View("GenericError");
        }

        [Route("error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(string id)



        {
            if (id == "404")
            {
                HttpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
                BaseViewModel baseViewModel = new BaseViewModel();
                baseViewModel.PageTitle = "Not Found | Exam-Answer";
                baseViewModel.PageBaseCanonicalUrl = pageBaseCanonicalUrl;
                baseViewModel.PageCanonicalUrl = $"{pageBaseCanonicalUrl}/error";
                return View("NotFound", baseViewModel);
            }
            else if (id == "500")
            {
                HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

            return View("GenericError");
        }

        [Route("/.well-known/pki-validation/37CB460FA42E085F9F1C49F02A1CD992.txt")]
        public string Cert()
        {
            return "4D4BB2B756DA903C4C7B37E700446258D4D3CEF34CA02E69E6A1C661872141CD comodoca.com 5e75e0d112ab9";
        }
    }
}