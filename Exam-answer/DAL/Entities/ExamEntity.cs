using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class ExamEntity : BaseEntity
    {
        public List<QuestionEntity> Questions { get; set; }
    }
}
