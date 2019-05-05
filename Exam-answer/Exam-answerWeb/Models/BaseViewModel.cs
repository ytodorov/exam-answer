using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_answerWeb.Models
{
    public class BaseViewModel
    {
        public int Id { get; set; }

        public int? Order { get; set; }

        public long DateCreatedInMemory { get; set; }
    }
}
