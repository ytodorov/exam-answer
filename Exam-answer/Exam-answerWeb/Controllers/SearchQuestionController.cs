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
                .Where(q => q.Content.Contains(text, StringComparison.InvariantCultureIgnoreCase)).ToList();

            int maxLengthTextInUi = 100;

            var baseUrl = Request.Scheme + "://" + Request.Host;

            foreach (SearchQuestionViewModel scvm in result)
            {
                int index = scvm.Content.IndexOf(text, StringComparison.InvariantCultureIgnoreCase);
                if (index + maxLengthTextInUi > scvm.Content.Length)
                {
                    scvm.TextInUI = scvm.Content.Substring(index);
                }
                else
                {
                    scvm.TextInUI = scvm.Content.Substring(index, maxLengthTextInUi);
                }
                scvm.Url = $"{baseUrl}/{scvm.ExamProvider}/{scvm.ExamName}/{scvm.QuestionName}";


            }



            return result;
        }
    }
}
