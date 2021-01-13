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
    [Route("microsoft/az-303")]
    public class MicrosoftAz303Controller : EaControllerBase
    {
        public MicrosoftAz303Controller(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public IActionResult Index()
        {
            var examViewModel = GetExamViewModelFromHttpContext();

            return View($"_ExamPartial", examViewModel);
        }
    }
}