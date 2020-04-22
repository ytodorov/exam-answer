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
        public MicrosoftAz900Controller(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public IActionResult Index()
        {
            var examViewModel = GetExamViewModelFromHttpContext();

            return View($"_ExamPartial", examViewModel);
        }
    }
}