using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class ContentEntity : BaseEntity
    {
        public string Text { get; set; }

        public QuestionEntity Question { get; set; }

        public int? QuestionId { get; set; }
    }
}
