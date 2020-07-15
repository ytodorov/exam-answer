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

        public static string GetAddsenseAdd(this IHtmlHelper helper, AdsenseType adsenseType = AdsenseType.ResponsiveAdSquare, bool? showAdd = true)
        {
            if (showAdd != true)
            {
                return string.Empty;
            }
            var randomInt = random.Next(0, 3);

            string result = string.Empty;

            switch (adsenseType)
            {
                case AdsenseType.ResponsiveAdSquare:
                    result = @"<amp-ad width=""100vw"" height=""320""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""7303740684""
     data-auto-format=""rspv""
     data-full-width="""">
  <div overflow=""""></div>
</amp-ad>";
                    break;
                case AdsenseType.ResponsiveAdHorizontal:
                    result = @"<amp-ad width=""100vw"" height=""320""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""6605505176""
     data-auto-format=""rspv""
     data-full-width="""">
  <div overflow=""""></div>
</amp-ad>";
                    break;
                case AdsenseType.ResponsiveAdVertical:
                    result = @"<amp-ad width=""100vw"" height=""320""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""9433745813""
     data-auto-format=""rspv""
     data-full-width="""">
  <div overflow=""""></div>
</amp-ad>";
                    break;
                case AdsenseType.Fixed_300_600:
                    result = @"<amp-ad
     layout=""fixed""
     width=""300""
     height=""600""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""8256395515"">
</amp-ad>";
                    break;
                case AdsenseType.Fixed_336_280:
                    result = @"<amp-ad
     layout=""fixed""
     width=""336""
     height=""280""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""3890802764"">
";
                    break;
                case AdsenseType.Fixed_300_250:
                    result = @"<amp-ad
     layout=""fixed""
     width=""300""
     height=""250""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""9062210728"">
";

                    break;
                case AdsenseType.Fixed_728_90:
                    result = @"<amp-ad
     layout=""fixed""
     width=""728""
     height=""90""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""8914871063"">
</amp-ad>";
                    break;
                case AdsenseType.Fixed_160_600:
                    result = @"<amp-ad
     layout=""fixed""
     width=""160""
     height=""600""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""2924139798"">
</amp-ad>
";
                    break;
                case AdsenseType.Fixed_970_90:
                    result = @"<amp-ad
     layout=""fixed""
     width=""970""
     height=""90""
     type=""adsense""
     data-ad-client=""ca-pub-2519209558650417""
     data-ad-slot=""1352037829"">
</amp-ad>";
                    break;
                case AdsenseType.Fixed_320_100:
                    result = @"<amp-ad
                         layout=""fixed""
                         width=""320""
                         height=""100""
                         type=""adsense""
                         data-ad-client=""ca-pub-2519209558650417""
                         data-ad-slot=""9840423003"">
                    </amp-ad>";

//                    result = @"<amp-ad width=320 height=100
//    type=""doubleclick""
//    data-slot=""/22029984878/Desktop_320x100"">
//</amp-ad>";
                    break;
                case AdsenseType.Fixed_320_50:
                    result = @"<amp-ad layout=""fixed""
                width=""320""
                height=""50""
                type=""adsense""
                data-ad-client=""ca-pub-2519209558650417""
                data-ad-slot=""7770886760"">
        </amp-ad>";
                    break;
                case AdsenseType.Fixed_300_250_AdManager:
                    result = @"<amp-ad width=300 height=250
    type=""doubleclick""
    data-slot=""/22029984878/Adsense_300_250"">
  <div placeholder></div>
  <div fallback></div>
</amp-ad>";
                    break;
                default:                    
                    break;
            }
            //if (helper.ViewContext.HttpContext.IsMobileBrowser())
            //{
            //    result = string.Empty;
            //}
            return result;
        }
    }
}