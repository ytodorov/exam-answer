namespace Exam_answerWeb.Models
{
    public class BaseViewModel
    {
        private string pageTitle;
        public string PageTitle
        {
            get
            {
                if (pageTitle?.Trim()?.EndsWith("Exam-Answer", System.StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    return pageTitle;
                }
                else
                {
                    return $"{pageTitle} | Exam-Answer";
                }
            }
            set
            {
                pageTitle = value;
            }
        }

        public string PageDescription { get; set; }

        public string PageKeywords { get; set; }

        public string PageMicrodata { get; set; }

        public string PageBaseCanonicalUrl { get; set; }

        public string PageCanonicalUrl { get; set; }

        public string SiteBaselUrl { get; set; }

        public string PageImageUrl { get; set; }

        public string PageImageAlt { get; set; }

        private string pageH1;
        public string PageH1
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(pageH1))
                {
                    return pageH1;
                }
                else
                {
                    var titleWithoutExamAnswer = pageTitle?.Replace("| Exam-Answer", string.Empty)?.Trim();
                    return titleWithoutExamAnswer;                         
                }
            }
            set
            {
                pageH1 = value;
            }
        }

        public int Id { get; set; }

        public int? Order { get; set; }

        public long DateCreatedInMemory { get; set; }
    }
}