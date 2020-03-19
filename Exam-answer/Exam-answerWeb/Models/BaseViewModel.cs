namespace Exam_answerWeb.Models
{
    public class BaseViewModel
    {
        public string PageTitle { get; set; }

        public string PageDescription { get; set; }

        public string PageKeywords { get; set; }

        public string PageMicrodata { get; set; }

        public string PageBaseCanonicalUrl { get; set; }

        public string PageCanonicalUrl { get; set; }

        public string SiteBaselUrl { get; set; }

        public string PageImageUrl { get; set; }

        public string PageImageAlt { get; set; }

        public string PageH1 { get; set; }




        public int Id { get; set; }

        public int? Order { get; set; }

        public long DateCreatedInMemory { get; set; }
    }
}