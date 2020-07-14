using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ITeacherService
    {
        Task<TeacherDTO> GetTeacherByIdAsync(int id); 
        //Task<TeacherDTO> GetTeacherByStudentIdAsync(int id);
    }
}
