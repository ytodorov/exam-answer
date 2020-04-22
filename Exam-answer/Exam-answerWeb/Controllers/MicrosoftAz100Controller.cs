using AutoMapper;
using DAL.Entities;
using Exam_answerWeb.Controllers;
using Exam_answerWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Exam_AnswerWeb.Controllers
{
    [Route("microsoft/az-100")]
    public class MicrosoftAz100Controller : EaControllerBase
    {
        public MicrosoftAz100Controller(ExamAnswerContext examAnswerContext,
            IHostingEnvironment env, IMapper mapper, IMemoryCache memoryCache, IConfiguration configuration) :
            base(examAnswerContext, env, mapper, memoryCache, configuration)
        {
        }

        public IActionResult Index()
        {
            var examViewModel = GetExamViewModelFromHttpContext();

            return View($"_ExamPartial", examViewModel);
        }
    }
}