using System;
using System.Collections.Generic;
using System.Text;

namespace IDP.Domain.Entities.BaseEntites
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            this.CreateDate = DateTimeOffset.UtcNow;
        }
        public Int64 ID { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
    }
}
