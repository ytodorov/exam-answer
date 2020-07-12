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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Exam_AnswerWeb.Controllers
{
    public class AdsController : EaControllerBase
    {
        public AdsController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public IActionResult Adsense_336_280()
        {
            return View();
        }

        public IActionResult Adsense_300_250()
        {
            return View();
        }

        public IActionResult Adsense_Responsive_Horizontal()
        {
            return View();
        }
    }
}