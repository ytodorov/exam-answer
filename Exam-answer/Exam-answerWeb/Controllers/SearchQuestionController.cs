using Exam_answerWeb.Infrastructure;
using Exam_answerWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_answerWeb.Controllers
{
    public class SearchQuestionController : Controller
    {

        public List<SearchQuestionViewModel> Read(string text)
        {
            if (text == null)
            {
                text = string.Empty;
            }
            List<SearchQuestionViewModel> result = StaticContent.AllQuestions
                .Where(q => q.Content.Contains(text)).Take(10).ToList();

            return result;
        }
    }
}
