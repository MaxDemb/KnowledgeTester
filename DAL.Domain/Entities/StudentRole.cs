using DAL.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Domain.Entities
{
    public class StudentRole: BaseEntity
    {
        public string UserId { get; set; }
    }
}
