using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class SchemaOrgTextEntity : BaseEntity
    {
        [NotMapped]
        public virtual string TextLd { get; set; }
    }
}
