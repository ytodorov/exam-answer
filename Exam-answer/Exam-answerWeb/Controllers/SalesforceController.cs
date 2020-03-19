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
    [Route("salesforce/crt-251")]
    public class SalesforceController : EaControllerBase
    {
        public SalesforceController(ExamAnswerContext examAnswerContext,
            IHostingEnvironment env, IMapper mapper, IMemoryCache memoryCache, IConfiguration configuration) :
            base(examAnswerContext, env, mapper, memoryCache, configuration)
        {
        }

        [Route("")]
        public IActionResult Index()
        {
            ExamEntity examEntity = examAnswerContext.Exams
               .Where(e => e.Provider.Equals("salesforce", StringComparison.InvariantCultureIgnoreCase) &&
                   e.Code.Equals("crt-251", StringComparison.InvariantCultureIgnoreCase))

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

            examViewModel.PageBaseCanonicalUrl = pageBaseCanonicalUrl;


            examViewModel.PageCanonicalUrl = $"{pageBaseCanonicalUrl}/salesforce/crt-251";
            examViewModel.PageH1 = "Exam CRT-251: Sales Cloud Consultant";
            examViewModel.PageDescription = "Prepare for Exam CRT-251: Sales Cloud Consultant. Free demo questions with answers and explanations";
            examViewModel.PageTitle = "Exam CRT-251: Sales Cloud Consultant | Exam-Answer";

            return View($"crt-251/index", examViewModel);
        }
    }
}