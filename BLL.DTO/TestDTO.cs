using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class TestDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime OpenedDate { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsOpen { get; set; }

        public int OwnerId { get; set; }
        //public Teacher Owner { get; set; }


        ////  public ICollection<Student> Students { get; set; }
        //public ICollection<Question> Questions { get; set; }
        //public ICollection<Result> Results { get; set; }
    }
}
