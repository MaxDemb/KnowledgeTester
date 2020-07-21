using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.EntityFramework.Configurations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly ITestService _testService;
        private readonly ITeacherService _teacherService;
        private readonly IMapper _mapper;
        public StudentController(ITeacherService teacherService, IStudentService studentService, ITestService testService, IMapper mapper)
        {
            this._teacherService = teacherService;
            this._studentService = studentService;
            this._testService = testService;
            this._mapper = mapper;
        }

        [HttpGet("{id}")]
        [Route("~/api/Students/{id}/Student")]
        public async Task<ActionResult<StudentDTO>> GetStudentByIdAsync(int id)
        {
            var res = await this._studentService.GetStudentByIdAsync(id);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);

        }


        [HttpGet("{id}")]
        [Route("~/api/Students/triedTest/{id}")]
        public async Task<ActionResult<IEnumerable<StudentDTO>>> GetStudentsThatTriedToPassTest(int id)
        {
            var res = await _studentService.getAllStudentsTriedToPassTest(id);
            if(res != null)
            {
                return Ok(res);
            }
            return BadRequest();
        }
            
    }
}
