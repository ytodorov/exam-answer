using AutoMapper;
using DAL.Entities;
using Exam_answerWeb.Controllers;
using Exam_answerWeb.Infrastructure;
using Exam_answerWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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

        [Route("test")]
        public IActionResult Test(int numberOfQuestions)
        {
            var examViewModel = GetExamViewModelFromHttpContext();

            var listOfRandomQuesionIds = RandomHelper.GetRandomIntValues(examViewModel.Questions.Count, numberOfQuestions);

            List<QuestionViewModel> newQuestions = new List<QuestionViewModel>();

            for (int i = 0; i < numberOfQuestions; i++)
            {
                newQuestions.Add(examViewModel.Questions[listOfRandomQuesionIds[i]]);
            }
            examViewModel.Questions.Clear();
            examViewModel.Questions.AddRange(newQuestions);

            return View($"_ExamPartial", examViewModel);
        }
    }
}