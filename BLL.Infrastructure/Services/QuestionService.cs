using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using BLL.DTO;
using DAL.Interfaces;
using BLL.Interfaces;
using System.Threading.Tasks;
using DAL.Domain.Entities;

namespace BLL.Infrastructure.Services
{
    public class QuestionService : BaseService, IQuestionService
    {
        public QuestionService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<ICollection<QuestionDTO>> GetQuestionsByTest(int id)
        {
            var test = await UnitOfWork.Test.GetByIdAsync(id);
            var questions = test.Questions;
            return Mapper.Map<IEnumerable<Question>, ICollection<QuestionDTO>>(questions);
        }

        public async Task<QuestionDTO> AddQuestionAsync(QuestionDTO question)
        {
            var questionDTO = Mapper.Map<QuestionDTO, Question>(question);
            await UnitOfWork.Question.CreateAsync(questionDTO);
            var allQuestions = await UnitOfWork.Question.GetAllAsync();
            var newQuestion = allQuestions.Where(x => x.Name == question.Name).FirstOrDefault();
            var newQuestionMapped = Mapper.Map<Question, QuestionDTO>(newQuestion);
            return newQuestionMapped;   
        }

        public async Task<IEnumerable<QuestionDTO>> GetQuestionsByTestId(int id)
        {
            var allQuestions = await UnitOfWork.Question.GetAllAsync();
            var result = allQuestions.Where(x => x.TestId == id);
            return Mapper.Map<IEnumerable<Question>, IEnumerable<QuestionDTO>>(result);
        }
    }
}
