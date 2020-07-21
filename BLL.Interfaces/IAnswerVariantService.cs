using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAnswerVariantService
    {
        Task<AnswerVariantDTO> CreateAnswerVariant(AnswerVariantDTO answerVariantDTO);
        Task<IEnumerable<AnswerVariantDTO>> getAnswerVariantsByQuestionIdAsync(int id);
        Task<AnswerVariantDTO> CheckAnswerVariant(AnswerVariantDTO answerVariant);
    }
}
