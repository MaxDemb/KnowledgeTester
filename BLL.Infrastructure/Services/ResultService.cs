using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BLL.DTO;
using DAL.Interfaces;
using BLL.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Infrastructure.Services
{
    public class ResultService : BaseService, IResultService
    {
        public ResultService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public ICollection<ResultDTO> GetAllResultsByTest(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<ResultDTO> GetAllResultsByStudentId(int id)
        {
            throw new NotImplementedException();
        }

        public ResultDTO GetResultByStudentAndTest(int studentId, int testId)
        {
            throw new NotImplementedException();

        }

        public async Task<bool> GetPassedBoolByStudentAsync(int studentId, int testId)
        {
            var allResults = await UnitOfWork.Result.GetAllAsync();
            var result = allResults.Where(x => x.StudentId == studentId && x.TestId == testId).FirstOrDefault();
            return result.Passed;
        }
    }
}
