using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public int? Order { get; set; }

        public long DateCreatedInMemory { get; set; } = StaticMethods.GetTicksNow();
    }
}
