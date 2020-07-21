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
        //public async Task<IEnumerable<StudentDTO>> GetStudentsByTeacherAsync(int id)
        //{
        //    var Students = await UnitOfWork.Student.GetAllAsync();
        //    var res = Students.Where(x => x.TeacherId == id);
        //    return Mapper.Map<IEnumerable<Student>, ICollection<StudentDTO>>(res);
        //}

        public async Task<StudentDTO> GetStudentByIdAsync(int id)
        {
            var res = await UnitOfWork.Student.GetByIdAsync(id);
            
            return Mapper.Map<Student, StudentDTO>(res);
        }

        public async Task<int> GetStudentdByUserIdAsync(string userId)
        {
            var allStudents = await UnitOfWork.Student.GetAllAsync();
            var result = allStudents.Where(x => x.UserId == userId).FirstOrDefault();
            var resultDTO = Mapper.Map<Student, StudentDTO>(result);
            return resultDTO.Id;
        }

        public async Task AddStudent(StudentDTO student)
        {
            var studentMapped = Mapper.Map<StudentDTO, Student>(student);
            await UnitOfWork.Student.CreateAsync(studentMapped);
        }

        public async Task<StudentDTO> GetStudentByUserIdAsync(string userId)
        {
            var allStudents = await UnitOfWork.Student.GetAllAsync();
            var Student = allStudents.Where(x => x.UserId == userId).FirstOrDefault();
            return Mapper.Map<Student, StudentDTO>(Student);
        }

        public async Task<IEnumerable<StudentDTO>> getAllStudentsTriedToPassTest(int id)
        {
            var allResults = await UnitOfWork.Result.GetAllAsync();
            var results = allResults.Where(x => x.TestId == id);
            var students = new List<Student>();
            foreach(var res in results)
            {
                var student = await UnitOfWork.Student.GetByIdAsync(res.StudentId);
                students.Add(student);
            }
            return Mapper.Map<IEnumerable<Student>, IEnumerable<StudentDTO>>(students);

        }
    }
}
