//using AutoMapper;
//using DAL.Entities;
//using Exam_answerWeb.Controllers;
//using Exam_answerWeb.Models;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Caching.Memory;
//using Microsoft.Extensions.Configuration;
//using System;
//using System.Linq;

//namespace Exam_AnswerWeb.Controllers
//{
//    [Route("salesforce/crt-251")]
//    public class SalesforceCrt251Controller : EaControllerBase
//    {
//        public SalesforceCrt251Controller(IServiceProvider serviceProvider) : base(serviceProvider)
//        {
//        }

//        public IActionResult Index()
//        {
//            var examViewModel = GetExamViewModelFromHttpContext();

//            return View($"_ExamPartial", examViewModel);
//        }
//    }
//}