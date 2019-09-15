namespace DAL.Entities
{
    public class ExplanationEntity : BaseEntity
    {
        public string Text { get; set; }

        public int? QuestionId { get; set; }

        public QuestionEntity Question { get; set; }
    }
}