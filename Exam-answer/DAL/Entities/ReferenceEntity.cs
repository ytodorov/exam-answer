namespace DAL.Entities
{
    public class ReferenceEntity : BaseEntity
    {
        public string Text { get; set; }

        public string Url { get; set; }

        public QuestionEntity Question { get; set; }

        public int? QuestionId { get; set; }
    }
}