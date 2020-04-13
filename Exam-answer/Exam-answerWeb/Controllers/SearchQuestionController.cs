using DAL.Entities;
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
        public List<SearchQuestionOldViewModel> Read(string text)
        {
            if (text == null)
            {
                text = string.Empty;
            }

            List<QuestionEntity> allQuestions = DataGenerator.AllExams.SelectMany(e => e.Questions).ToList();

            List<QuestionEntity> result = allQuestions
                .Where(q => q.ContentText.Contains(text, StringComparison.InvariantCultureIgnoreCase)).ToList();

            int maxLengthTextInUi = 100;

            string baseUrl = Request.Scheme + "://" + Request.Host;

            List<SearchQuestionOldViewModel> list = new List<SearchQuestionOldViewModel>();

            foreach (QuestionEntity question in result)
            {
                SearchQuestionOldViewModel sqvm = new SearchQuestionOldViewModel();
                int index = question.ContentText.IndexOf(text, StringComparison.InvariantCultureIgnoreCase);
                if (index + maxLengthTextInUi > question.ContentText.Length)
                {
                    sqvm.TextInUI = question.ContentText.Substring(index);
                }
                else
                {
                    sqvm.TextInUI = question.ContentText.Substring(index, maxLengthTextInUi);
                }

                int realOrder = question.Exam.Questions.OrderBy(qs => qs.Order).ToList().IndexOf(question) + 1;

                sqvm.Url = $"{baseUrl}/{question.Exam.Provider}/{question.Exam.Code}/question{realOrder}";
                sqvm.Url = sqvm.Url.ToLowerInvariant();
                list.Add(sqvm);
            }

            return list;
        }
    }
}