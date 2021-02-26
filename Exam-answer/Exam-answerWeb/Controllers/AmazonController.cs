//using AutoMapper;
//using DAL.Entities;
//using Exam_answerWeb.Controllers;
//using Exam_answerWeb.Models;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Caching.Memory;
//using Microsoft.Extensions.Configuration;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace Exam_AnswerWeb.Controllers
//{
//    [Route("amazon")]
//    public class AmazonController : EaControllerBase
//    {
//        public AmazonController(IServiceProvider serviceProvider) : base(serviceProvider)
//        {
//        }

//        public IActionResult Index()
//        {
//            var exams = examAnswerContext.Exams
//               .Where(e => e.Provider.Equals("Amazon", StringComparison.InvariantCultureIgnoreCase))

//               .Include(e => e.Questions)
//               .ThenInclude(q => q.Contents)

//               .Include(e => e.Questions)
//               .ThenInclude(q => q.Answers)

//               .Include(e => e.Questions)
//               .ThenInclude(q => q.Explanations)

//               .Include(e => e.Questions)
//               .ThenInclude(q => q.References)

//               .AsNoTracking()
//               .OrderBy(s => s.Order)
//               .ToList();

//            List<ExamViewModel> examViewModels = new List<ExamViewModel>();
//            foreach (var exam in exams)
//            {
//                var vm = mapper.Map<ExamViewModel>(exam);
//                examViewModels.Add(vm);
//            }

//            TempData["exams"] = examViewModels;

//            BaseViewModel baseViewModel = new BaseViewModel()
//            {
//                PageBaseCanonicalUrl = pageBaseCanonicalUrl,
//                PageH1 = "Exams from Amazon",
//                PageDescription = "Browse all exams from Amazon",
//                PageTitle = "Exams from Amazon",
//                PageCanonicalUrl = pageBaseCanonicalUrl + "/amazon",
//            };

//            return View($"_ExamsProviderPartial", baseViewModel);
//        }
//    }
//}