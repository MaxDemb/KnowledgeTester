using System;
using System.Collections.Generic;
using DAL.Domain.Entities;

namespace DAL.Domain.Base
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public int Year { get; set; }
        //public int Age { get; set; }
        //public bool IsActive { get; set; }
        //public DateTime RegistrationDate { get; set; }
        //public string ProfileImagePath { get; set; }

   //     public ICollection<Test> Tests { get; set; } = new List<Test>();

    }
}
