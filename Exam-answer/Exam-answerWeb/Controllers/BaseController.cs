using AutoMapper;
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

        protected readonly IMapper mapper;

        public BaseController(ExamAnswerContext examAnswerContext, IHostingEnvironment env, IMapper mapper)
        {
            this.examAnswerContext = examAnswerContext;
            this.env = env;
            this.mapper = mapper;
        }
    }
}
