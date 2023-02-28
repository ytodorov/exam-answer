using ExamAnswerRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamAnswerRazor.Pages
{
    public class MyPageModel : PageModel
    {
        public IActionResult OnGet()
        {
            string[] segments = Request.RouteValues["slug"]?.ToString()?.Split('/');

            var length = segments?.Length;

            if (length == 1)
            {
                return Partial("_ProviderPartial", new ProviderPartialViewModel() { ProviderName = segments[0] });
            }

            return null;

            // Do something with the segments...
        }
    }
}
