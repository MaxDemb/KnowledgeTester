using DAL.Domain.Base;
using System.Collections.Generic;

namespace DAL.Domain.Entities
{
    public class Question:BaseEntity
    {
        public string QuestionText { get; set; }
        public string QuestionRightAnswer { get; set; }
        public string QuestionStudentAnswer { get; set; }


        public ICollection<AnswerVariant> Answers { get; set; } = new List<AnswerVariant>();

    }
}
