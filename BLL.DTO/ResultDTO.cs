using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class ResultDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RightAnswers { get; set; }
        public bool Passed { get; set; }
        public int TestId { get; set; }

        public int StudentId { get; set; }
    }
}
