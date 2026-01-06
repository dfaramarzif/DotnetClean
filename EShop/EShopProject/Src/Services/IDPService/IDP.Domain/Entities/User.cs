using IDP.Domain.Entities.BaseEntites;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDP.Domain.Entities
{
    public class User : BaseEntity
    {
        public required string FulleName { get; set; }
        public required string NationalCode { get; set; }
    }
}
