using DAL.Domain.Base;
using System;
using System.Collections.Generic;


namespace DAL.Domain.Entities
{
    public class Teacher : BaseEntity
    {

        public int Age { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string ProfileImagePath { get; set; }

        
        public ICollection<Student> Students { get; set; }
        public ICollection<Test> Tests { get; set; }
    }
}