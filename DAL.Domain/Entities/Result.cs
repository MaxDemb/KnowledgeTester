using System;
using System.Collections;
using System.Collections.Generic;
using DAL.Domain.Base;

namespace DAL.Domain.Entities
{
    public class Result:BaseEntity 
    {

        //public int TeacherId { get; set; }
        //public Teacher Teacher { get; set; }

        //public int Mark { get; set; }
        // public bool Passed { get; set; }


        public int RightAnswers { get; set; }

        public bool Passed { get; set; }
        public int TestId { get; set; }
        public Test Test { get; set; }
        
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
