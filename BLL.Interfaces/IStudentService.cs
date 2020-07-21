using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IStudentService
    {
        //Task<IEnumerable<StudentDTO>> GetStudentsByTeacherAsync(int id);
        Task<StudentDTO> GetStudentByIdAsync(int id);
        Task AddStudent(StudentDTO student);

        Task<int> GetStudentdByUserIdAsync(string userId);
    }
}
