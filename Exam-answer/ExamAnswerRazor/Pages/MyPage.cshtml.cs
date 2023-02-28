using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamAnswerRazor.Pages
{
    public class MyPageModel : PageModel
    {
        public void OnGet()
        {
            string[] segments = Request.RouteValues["slug"]?.ToString()?.Split('/');
            // Do something with the segments...
        }
    }
}
