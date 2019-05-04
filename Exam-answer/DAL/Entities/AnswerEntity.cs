using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class AnswerEntity : BaseEntity
    {
        public string Text { get; set; }

        public bool? IsCorrect { get; set; }
    }
}
