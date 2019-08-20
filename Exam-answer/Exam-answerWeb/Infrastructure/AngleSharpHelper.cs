using AngleSharp.Html;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_answerWeb.Infrastructure
{
    public static class AngleSharpHelper
    {
        public static string PrettifyHtml(string newContent)
        {
            AngleSharp.Html.Parser.HtmlParser parser = new AngleSharp.Html.Parser.HtmlParser();
            AngleSharp.Html.Dom.IHtmlDocument document = parser.ParseDocument(newContent);

            StringWriter sw = new StringWriter();
            document.ToHtml(sw, new PrettyMarkupFormatter());
            return sw.ToString();
        }
    }
}
