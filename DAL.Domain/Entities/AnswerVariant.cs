using DAL.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Domain.Entities
{
    public class AnswerVariant:BaseEntity
    {
        public bool Right { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
