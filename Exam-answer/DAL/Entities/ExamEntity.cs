using System.Collections.Generic;

namespace DAL.Entities
{
    public class ExamEntity : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Provider { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<QuestionEntity> Questions { get; set; }

        public string UdemyLinkUrl { get; set; }

        public string UdemyLinkMessage { get; set; }

        public string UdemyMessage { get; set; }

        public bool ShowUdemy { get; set; }
    }
}