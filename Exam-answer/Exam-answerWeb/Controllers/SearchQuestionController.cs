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
                .Where(q => q.Content.Contains(text)).ToList();

            int maxLengthTextInUi = 100;

            foreach (SearchQuestionViewModel searchQuestionViewModel in result)
            {
                int index = searchQuestionViewModel.Content.IndexOf(text);
                if (index + maxLengthTextInUi > searchQuestionViewModel.Content.Length)
                {
                    searchQuestionViewModel.TextInUI = searchQuestionViewModel.Content.Substring(index);
                }
                else
                {
                    searchQuestionViewModel.TextInUI = searchQuestionViewModel.Content.Substring(index, maxLengthTextInUi);
                }
            }

            return result;
        }
    }
}
