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
    }
}
