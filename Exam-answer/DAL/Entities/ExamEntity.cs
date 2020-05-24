using System.Collections.Generic;

namespace DAL.Entities
{
    public class ExamEntity : BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Provider { get; set; }

        public string ExamProviderUrl { get; set; }

        public string ExamUrl { get; set; }

        public string PageTitle { get; set; }

        public string PageDescription { get; set; }

        public List<QuestionEntity> Questions { get; set; }

        public string UdemyLinkUrl { get; set; }

        public string UdemyLinkMessage { get; set; }

        public string UdemyMessage { get; set; }

        public bool ShowUdemy { get; set; }
    }
}