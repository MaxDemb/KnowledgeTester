using DAL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TestId { get; set; }
        public string RightAnswer { get; set; }
        //public Test Test { get; set; }
        //public ICollection<AnswerVariant> Answers { get; set; } = new List<AnswerVariant>();

    }
}
