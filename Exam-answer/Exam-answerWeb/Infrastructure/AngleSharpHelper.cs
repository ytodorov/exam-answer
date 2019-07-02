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
            var parser = new AngleSharp.Html.Parser.HtmlParser();
            var document = parser.ParseDocument(newContent);

            var sw = new StringWriter();
            document.ToHtml(sw, new PrettyMarkupFormatter());
            return sw.ToString();
        }
    }
}
