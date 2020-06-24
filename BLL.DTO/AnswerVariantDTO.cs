using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class AnswerVariantDTO
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public bool Right { get; set; }
        public int QuestionId { get; set; }
    }
}
