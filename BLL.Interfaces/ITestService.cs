using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ITestService
    {
        Task<IEnumerable<TestDTO>> GetTestsByTeacherAsync(int id);
        Task<IEnumerable<TestDTO>> GetTestsByStudentIdAsync(int id);
        Task<TestDTO> GetTestByIdAsync(int id);
        Task<TestDTO> CreateTest(TestDTO testDTO);
        Task<IEnumerable<TestDTO>> GetAllTestsAsync();
    }
}
