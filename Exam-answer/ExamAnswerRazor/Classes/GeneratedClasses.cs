namespace ExamAnswerRazor.Classes
{
    // GeneratedClasses myDeserializedClass = JsonConvert.DeserializeObject<GeneratedClasses>(myJsonResponse);
    public class Exam
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Provider { get; set; }
        public string ImageUrl { get; set; }
        public string BreadcrumbJsonLd { get; set; }
        public int QuestionsCount { get; set; }
        public List<Question> Questions { get; set; }
        public int OrderId { get; set; }
        public string Key { get; set; }
        public string CanonicalUrl { get; set; }
        public List<string> Description { get; set; }
    }

    public class Provider
    {
        public string Name { get; set; }
        public string BreadcrumbJsonLd { get; set; }
        public string ImageUrl { get; set; }
        public int ExamsCount { get; set; }
        public int QuestionsCount { get; set; }
        public List<Exam> Exams { get; set; }
        public int OrderId { get; set; }
        public string Key { get; set; }
        public string CanonicalUrl { get; set; }
        public List<object> Description { get; set; }
    }

    public class Question
    {
        public string ProviderName { get; set; }
        public string ExamName { get; set; }
        public int Type { get; set; }
        public int OrderId { get; set; }
        public string CanonicalUrl { get; set; }
        public List<object> Description { get; set; }
        public string ImageUrl { get; set; }
    }

    public class GeneratedClasses
    {
        public List<Provider> Providers { get; set; }
    }


}
