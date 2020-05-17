using Exam_answerWeb.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Exam_answerWeb.Infrastructure
{
    public static class HtmlHelperExtensions
    {
        private static Random random = new Random();

        public static string GetNextId(this IHtmlHelper helper, bool returnLast = false)
        {
            object currentId = helper.ViewContext.HttpContext.Items["currentId"];
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
            object currentId = helper.ViewContext.HttpContext.Items["questionId"];
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

        public static string GetMicrodata(this IHtmlHelper helper)
        {
            string microdata = string.Empty;
            if (helper.ViewContext.ViewData["hasMicrodata"] != null)
            {
                microdata = helper.ViewContext.ViewData["microdata"]?.ToString();
            }
            return microdata;
        }

        public static string GetRandomAddsenseAdd(this IHtmlHelper helper)
        {
            var randomInt = random.Next(0, 3);

            string result = string.Empty;

            switch (randomInt)
            {
                case 0:
                    result = @"<amp-ad
     layout=""fixed""
     width=""728""
     height=""90""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""8914871063"">
</amp-ad>";
                    break;
                case 1:
                    result = @"<amp-ad
     layout=""fixed""
     width=""300""
     height=""250""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""9062210728"">
</amp-ad><amp-ad
     layout=""fixed""
     width=""300""
     height=""250""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""9062210728"">
</amp-ad>";
                    break;
                case 2:
                    result = @"<amp-ad
     layout=""fixed""
     width=""336""
     height=""280""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""3890802764"">
</amp-ad><amp-ad
     layout=""fixed""
     width=""336""
     height=""280""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""3890802764"">
</amp-ad>";
                    break;
                default:
                    result = @"<amp-ad width=""100vw"" height=""320""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""6605505176""
     data-auto-format=""rspv""
     data-full-width="""">
  <div overflow=""""></div>
</amp-ad>";
                    break;

                    
            }

            bool? isMobile = helper?.ViewContext?.HttpContext?.IsMobileBrowser();

            if (isMobile == true)
            {
                result = @"<amp-ad width=""100vw"" height=""320""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""6605505176""
     data-auto-format=""rspv""
     data-full-width="""">
  <div overflow=""""></div>
</amp-ad>";
            }

            return result;
        }
    }
}