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
    [Route("salesforce/adm-201")]
    public class SalesforceAdm201Controller : EaControllerBase
    {
        public SalesforceAdm201Controller(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public IActionResult Index()
        {
            var examViewModel = GetExamViewModelFromHttpContext();

            return View($"_ExamPartial", examViewModel);
        }
    }
}