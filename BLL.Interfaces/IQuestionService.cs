﻿using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IQuestionService
    {
        Task<ICollection<QuestionDTO>> GetQuestionsByTest(int id);
        Task<QuestionDTO> AddQuestionAsync(QuestionDTO question);

        Task<IEnumerable<QuestionDTO>> GetQuestionsByTestId(int id);
    }

}
