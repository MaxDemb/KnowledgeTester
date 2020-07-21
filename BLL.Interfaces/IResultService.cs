using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IResultService
    {
        //Task<bool> GetPassedBoolByStudentAsync(int studentId, int testId);
        Task<ResultDTO> AddResultAsync(ResultDTO modelDTO);
        Task UpdateResultAsync(ResultDTO modelDTO);
        Task<ResultDTO> ResultExist(ResultDTO model);
    }
}
