using DAL.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace DAL.Domain.Entities
{
    public class Student : BaseEntity
    {



      //  public int TeacherId { get; set; }
      //  public Teacher Teachers { get; set; }

        public ICollection<Result> Results { get; set; }
    }
}
