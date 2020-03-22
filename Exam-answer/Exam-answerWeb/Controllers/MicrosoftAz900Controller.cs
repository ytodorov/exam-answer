using AutoMapper;
using DAL.Entities;
using Exam_answerWeb.Controllers;
using Exam_answerWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace Exam_AnswerWeb.Controllers
{
    [Route("microsoft/az-900")]
    public class MicrosoftAz900Controller : EaControllerBase
    {
        public MicrosoftAz900Controller(ExamAnswerContext examAnswerContext,
            IHostingEnvironment env, IMapper mapper, IMemoryCache memoryCache, IConfiguration configuration) :
            base(examAnswerContext, env, mapper, memoryCache, configuration)
        {
        }

        [Route("")]
        public IActionResult Index()
        {
            ExamEntity examEntity = examAnswerContext.Exams
               .Where(e => e.Provider.Equals("microsoft", StringComparison.InvariantCultureIgnoreCase) &&
                   e.Code.Equals("az-900", StringComparison.InvariantCultureIgnoreCase))

               .Include(e => e.Questions)
               .ThenInclude(q => q.Contents)

               .Include(e => e.Questions)
               .ThenInclude(q => q.Answers)

               .Include(e => e.Questions)
               .ThenInclude(q => q.Explanations)

               .Include(e => e.Questions)
               .ThenInclude(q => q.References)

               .AsNoTracking()

               .FirstOrDefault();

            ExamViewModel examViewModel = mapper.Map<ExamViewModel>(examEntity);
            examViewModel.PageBaseCanonicalUrl = examViewModel.PageBaseCanonicalUrl = pageBaseCanonicalUrl;

            examViewModel.PageCanonicalUrl = $"{pageBaseCanonicalUrl}/microsoft/az-900";
            examViewModel.PageH1 = "Exam AZ-900: Microsoft Azure Fundamentals";
            examViewModel.PageDescription = "Prepare for Exam AZ-900: Microsoft Azure Fundamentals. Free demo questions with answers and explanations";
            examViewModel.PageTitle = "Exam AZ-900: Microsoft Azure Fundamentals | Exam-Answer";

            examViewModel.PageMicrodata = $@"<script type=""application/ld+json"">
    {{
      ""@context"": ""http://schema.org"",
      ""@type"": ""Webpage"",
      ""url"": ""{examViewModel.PageCanonicalUrl}"",
      ""name"": ""{examViewModel.PageTitle}"",
      ""headline"": ""{examViewModel.PageTitle}"",
      ""description"": ""{examViewModel.PageDescription}"",
      ""mainEntityOfPage"": {{
        ""@type"": ""WebPage"",
        ""@id"": ""{examViewModel.PageCanonicalUrl}""
      }},
      ""publisher"": {{
        ""@type"": ""Organization"",
        ""name"": ""{examViewModel.PageCanonicalUrl}"",
        ""logo"": {{
          ""url"": ""{examViewModel.PageCanonicalUrl}/android-chrome-512x512.png"",
          ""width"": 512,
          ""height"": 512,
          ""@type"": ""ImageObject""
        }}
      }},
      ""image"": {{
        ""@type"": ""ImageObject"",
        ""url"": ""{examViewModel.PageCanonicalUrl}/android-chrome-512x512.png"",
        ""width"": 512,
        ""height"": 512
      }}
    }}";
            return View($"az-900/index", examViewModel);
        }
    }
}