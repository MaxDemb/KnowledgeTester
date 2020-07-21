using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BLL.DTO;
using DAL.Interfaces;
using BLL.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using DAL.Domain.Entities;

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

        public async Task<ResultDTO> AddResultAsync(ResultDTO modelDTO)
        {
            var model = Mapper.Map<ResultDTO, Result>(modelDTO);
            await UnitOfWork.Result.CreateAsync(model);
            return modelDTO;
        }

        public async Task UpdateResultAsync(ResultDTO modelDTO)
        {
            var model = Mapper.Map<ResultDTO, Result>(modelDTO);
            var oldModel = new Result
            {
                Name = model.Name,
                RightAnswers = 0,
                TestId = model.TestId,
                StudentId = model.StudentId
            };
            UnitOfWork.Result.Remove(oldModel);
            UnitOfWork.Result.CreateAsync(model);
        }

        public async Task<ResultDTO> ResultExist(ResultDTO model)
        {
            var allResults = await UnitOfWork.Result.GetAllAsync();
            var res = allResults.Where(x => x.TestId == model.TestId && x.StudentId == model.StudentId).FirstOrDefault();
            return Mapper.Map<Result, ResultDTO>(res);
        }

        //public async Task<bool> GetPassedBoolByStudentAsync(int studentId, int testId)
        //{
        //    var allResults = await UnitOfWork.Result.GetAllAsync();
        //    var result = allResults.Where(x => x.StudentId == studentId && x.TestId == testId).FirstOrDefault();
        //    return result.Passed;
        //}
    }
}
