using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_answerWeb.Infrastructure
{
    public static class HtmlHelperExtensions
    {
        public static string GetNextId(this IHtmlHelper helper, bool returnLast = false)
        {            
            var currentId = helper.ViewContext.HttpContext.Items["currentId"];
            if (returnLast)
            {
                return currentId?.ToString();
            }
            if (currentId == null)
            {
                currentId = 1;
            }
            else
            {
                int currentIntId = (int)currentId + 1;
                currentId = currentIntId;
            }
            helper.ViewContext.HttpContext.Items["currentId"] = currentId;
            return currentId?.ToString();
        }

        public static string GetNextQuestionId(this IHtmlHelper helper, bool returnLast = false)
        {
            var currentId = helper.ViewContext.HttpContext.Items["questionId"];
            if (returnLast)
            {
                return currentId?.ToString();
            }
            if (currentId == null)
            {
                currentId = 1;
            }
            else
            {
                int currentIntId = (int)currentId + 1;
                currentId = currentIntId;
            }
            helper.ViewContext.HttpContext.Items["questionId"] = currentId;
            return currentId?.ToString();
        }
    }
}
