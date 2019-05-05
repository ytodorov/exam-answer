using DAL.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_answerWeb.Controllers
{
    public class BaseController : Controller
    {
        protected ExamAnswerContext examAnswerContext;
        protected readonly IHostingEnvironment env;

        public BaseController(ExamAnswerContext examAnswerContext, IHostingEnvironment env)
        {
            this.examAnswerContext = examAnswerContext;
            this.env = env;
        }
    }
}
