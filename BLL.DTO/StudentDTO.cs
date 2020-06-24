using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string ProfileImagePath { get; set; }


    }
}
