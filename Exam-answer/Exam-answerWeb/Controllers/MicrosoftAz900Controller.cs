using AutoMapper;
using DAL.Entities;
using Exam_answerWeb.Controllers;
using Exam_answerWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Linq;

namespace Exam_AnswerWeb.Controllers
{
    [Route("microsoft/az-900")]
    public class MicrosoftAz900Controller : EaControllerBase
    {
        public MicrosoftAz900Controller(ExamAnswerContext examAnswerContext, IHostingEnvironment env, IMapper mapper, IMemoryCache memoryCache) :
            base(examAnswerContext, env, mapper, memoryCache)
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

            return View($"az-900/index", examViewModel);
        }
    }
}