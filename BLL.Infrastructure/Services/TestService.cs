using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BLL.DTO;
using DAL.Interfaces;
using BLL.Interfaces;
using System.Threading.Tasks;
using System.Linq;
using DAL.Domain.Entities;
using System.Security.Cryptography.X509Certificates;

namespace BLL.Infrastructure.Services
{
    public class TestService : BaseService, ITestService
    {
        public TestService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<TestDTO>> GetTestsByTeacherAsync(int id)
        {
            var allTests = await this.UnitOfWork.Test.GetAllAsync();
            var result = allTests.Where(x => x.OwnerId == id);
            return Mapper.Map<IEnumerable<Test>, List<TestDTO>>(result);
        }

        //CHANGE LOGIC!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public async Task<IEnumerable<TestDTO>> GetTestsByStudentIdAsync(int id)
        {
            var student = await UnitOfWork.Student.GetByIdAsync(id);

            // var teacher = await UnitOfWork.Teacher.GetByIdAsync(student.TeacherId);

            var tests = await UnitOfWork.Test.GetAllAsync();
            var res = tests;//.Where(x => x.OwnerId == teacher.Id);
            return Mapper.Map<IEnumerable<Test>, List<TestDTO>>(res);
        }


        public async Task<TestDTO> GetTestByIdAsync(int id)
        {
            var result = await UnitOfWork.Test.GetByIdAsync(id);
            return Mapper.Map<Test, TestDTO>(result);
        }

        public async Task<TestDTO> CreateTest(TestDTO testDTO)
        {
            var test = Mapper.Map<TestDTO, Test>(testDTO);
            var teacher = await UnitOfWork.Teacher.GetByIdAsync(test.OwnerId);
            if(teacher == null)
            {
                throw new Exception("Foreign key is not right");
            }
            await UnitOfWork.Test.CreateAsync(test);
           
            return testDTO;
        }
    }
}
