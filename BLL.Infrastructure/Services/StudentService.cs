using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BLL.DTO;
using DAL.Interfaces;
using BLL.Interfaces;
using System.Linq;
using DAL.Domain.Entities;
using System.Threading.Tasks;

namespace BLL.Infrastructure.Services
{
    public class StudentService : BaseService, IStudentService
    {
        public StudentService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        //ICollection<StudentDTO>
        public async Task<IEnumerable<StudentDTO>> GetStudentsByTeacherAsync(int id)
        {
            var Students = await UnitOfWork.Student.GetAllAsync();
            var res = Students.Where(x => x.TeacherId == id);
            return Mapper.Map<IEnumerable<Student>, ICollection<StudentDTO>>(res);
        }

        public async Task<StudentDTO> GetStudentByIdAsync(int id)
        {
            var res = await UnitOfWork.Student.GetByIdAsync(id);
            
            return Mapper.Map<Student, StudentDTO>(res);
        }


        public async Task AddStudent(StudentDTO student)
        {
            var studentMapped = Mapper.Map<StudentDTO, StudentRole>(student);
            await UnitOfWork.StudentRole.CreateAsync(studentMapped);
        }
    }
}
