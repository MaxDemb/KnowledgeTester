using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAL.Domain.Base;

namespace DAL.Domain.Entities
{
    public class Test : BaseEntity
    {

        public DateTime CreationDate { get; set; }
        public DateTime OpenedDate { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsOpen { get; set; }

        public int OwnerId { get; set; }
        public Teacher Owner { get; set; }


       // public ICollection<Student> Students { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<Result> Results { get; set; }
    }
}
