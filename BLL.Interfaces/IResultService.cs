using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IResultService
    {
        Task<bool> GetPassedBoolByStudentAsync(int studentId, int testId);
    }
}
