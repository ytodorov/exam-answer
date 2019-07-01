using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Entities;
using Exam_answerWeb.Controllers;
using Exam_answerWeb.Infrastructure;
using Exam_answerWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;


namespace Exam_AnswerWeb.Controllers
{
    [Route("salesforce/crt-251")]
    public class SalesforceController : EaControllerBase
    {
        public SalesforceController(ExamAnswerContext examAnswerContext, IHostingEnvironment env, IMapper mapper) :
            base(examAnswerContext, env, mapper)
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

            var examViewModel = mapper.Map<ExamViewModel>(examEntity);

            return View($"crt-251/index", examViewModel);
        }

        //[ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
        [Route("question{id}")]
        public IActionResult QuestionGeneric(string id)
        {
            var res = QuestionGeneric("salesforce", "crt-251", id);

            return res;
        }

    }
}