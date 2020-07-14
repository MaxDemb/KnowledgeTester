using DAL.Domain.Base;
using System;
using System.Collections.Generic;


namespace DAL.Domain.Entities
{
    public class Teacher : BaseEntity
    {

        
      //  public ICollection<Student> Students { get; set; }
        public ICollection<Test> Tests { get; set; }
    }
}