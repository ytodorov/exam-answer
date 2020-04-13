using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.IO;
using System.Linq;
using System.Text;

namespace Exam_answerWeb.Extensions
{
    public static class ViewResultExtensions
    {
        public static string ToHtml(this ViewResult result, HttpContext httpContext)
        {
            try
            {
                IRoutingFeature feature = httpContext.Features.Get<IRoutingFeature>();
                RouteData routeData = feature.RouteData;
                string viewName = result.ViewName ?? routeData.Values["action"] as string;
                ActionContext actionContext = new ActionContext(httpContext, routeData, new ControllerActionDescriptor());
                IOptions<MvcViewOptions> options = httpContext.RequestServices.GetRequiredService<IOptions<MvcViewOptions>>();
                Microsoft.AspNetCore.Mvc.ViewFeatures.HtmlHelperOptions htmlHelperOptions = options.Value.HtmlHelperOptions;
                Microsoft.AspNetCore.Mvc.ViewEngines.ViewEngineResult viewEngineResult = result.ViewEngine?.FindView(actionContext, viewName, true) ?? options.Value.ViewEngines.Select(x => x.FindView(actionContext, viewName, true)).FirstOrDefault(x => x != null);
                Microsoft.AspNetCore.Mvc.ViewEngines.IView view = viewEngineResult.View;
                StringBuilder builder = new StringBuilder();

                using (StringWriter output = new StringWriter(builder))
                {
                    ViewContext viewContext = new ViewContext(actionContext, view, result.ViewData, result.TempData, output, htmlHelperOptions);

                    view
                        .RenderAsync(viewContext)
                        .GetAwaiter()
                        .GetResult();
                }

                return builder.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}