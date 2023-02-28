using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamAnswerRazor.Pages
{
    public class ProviderModel : PageModel
    {
        public string ProviderName { get; set; }

        public void OnGet()
        {
        }
    }
}
