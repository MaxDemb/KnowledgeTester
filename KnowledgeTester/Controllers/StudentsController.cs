using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeTester.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private readonly IStudentService _studentService;
        private readonly ITestService _testService;
        private readonly ITeacherService _teacherService;
        private readonly IMapper _mapper;
        public StudentsController(ITeacherService teacherService,IStudentService studentService, ITestService testService, IMapper mapper)
        {
            this._teacherService = teacherService;
            this._studentService = studentService;
            this._testService = testService;
            this._mapper = mapper;
        }


           /// !!!
           /// 



        // GET: api/Student/5
        //[HttpGet("{id}")]
        //[Route("~/api/Students/{id}/Student")]
        //public async Task<ActionResult<StudentDTO>> GetStudentByIdAsync(int id)
        //{
        //    var res = await this._studentService.GetStudentByIdAsync(id);
        //    if(res == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(res);

        //}

        //[HttpGet("{id}")]
        //[Route("~/api/Students/{id}/Teacher")]
        //public async Task<ActionResult<TeacherDTO>> GetTeacherByStudentIdAsync(int id)
        //{
        //    var res = await this._teacherService.GetTeacherByStudentIdAsync(id);
        //    if (res == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(res);

        //}


        [HttpGet("{id}")]
        [Route("~/api/Students/{id}/Tests")]
        public async Task<ActionResult<TeacherDTO>> GetTestsByStudentIdAsync(int id)
        {
            var res = await _testService.GetTestsByStudentIdAsync(id);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);

        }

    }
}
