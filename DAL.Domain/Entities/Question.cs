using DAL.Domain.Base;
using System.Collections.Generic;

namespace DAL.Domain.Entities
{
    public class Question:BaseEntity
    {
        public string RightAnswer { get; set; }



        public int TestId { get; set; }
        public Test Test { get; set; }
        public ICollection<AnswerVariant> Answers { get; set; } = new List<AnswerVariant>();

    }
}
