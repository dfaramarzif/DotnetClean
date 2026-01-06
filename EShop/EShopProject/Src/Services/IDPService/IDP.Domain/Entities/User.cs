using IDP.Domain.Entities.BaseEntites;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDP.Domain.Entities
{
    public class User : BaseEntity
    {
        public required string FullName { get; set; }
        public required string NationalCode { get; set; }
        public required string UserId { get; set; }
        public required string HashedPassword { get; set; }
        public required string Salt { get; set; }
    }
}
