using ExamAnswerRazor.Classes;
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
                var providerSegment = segments[0];
                var provider = Constants.ProvidersAndExams.Providers.FirstOrDefault(f => f.Name?.Equals(providerSegment, StringComparison.InvariantCultureIgnoreCase) == true);
                if (provider != null)
                {
                    return Partial("_ProviderPartial", provider);
                }
                return NotFound();
            }
            else if (length == 2)
            {
                var providerSegment = segments[0];
                var examSegment = segments[1];
                var provider = Constants.ProvidersAndExams.Providers.FirstOrDefault(f => f.Name?.Equals(providerSegment, StringComparison.InvariantCultureIgnoreCase) == true);
                if (provider != null)
                {
                    var exam = provider.Exams.FirstOrDefault(f => f.Code?.Equals(examSegment, StringComparison.InvariantCultureIgnoreCase) == true);
                    if (exam != null)
                    {
                        return Partial("_ExamPartial", exam);
                    }
                }
                return NotFound();
            }

            return null;

            // Do something with the segments...
        }
    }
}
