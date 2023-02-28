using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamAnswerNew.Pages
{
    public class AdModel : PageModel
    {
        [FromQuery]
        public string Url { get; set; }
        public void OnGet()
        {

        }
    }
}
