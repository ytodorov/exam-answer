using AngleSharp.Html;
using System.IO;

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