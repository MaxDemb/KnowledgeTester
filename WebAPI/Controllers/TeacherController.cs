using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        private readonly IStudentService _studentService;
        private readonly ITestService _testService;
        private readonly IMapper _mapper;
        public TeacherController(ITeacherService teacherService, IStudentService studentService, ITestService testService, IMapper mapper)
        {
            this._teacherService = teacherService;
            this._studentService = studentService;
            this._testService = testService;
            this._mapper = mapper;
        }

        //// GET: api/Teachers
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<TeacherDTO>>> GetTeachers()
        //{
        //    throw new NotImplementedException();
        //    //return await _context.Teachers.ToListAsync();
        //}

        // GET: api/Teachers/5
        [HttpGet("{id}")]
        [Route("~/api/Teachers/{id}/Teacher")]
        public async Task<ActionResult<TeacherDTO>> GetTeacher(int id)
        {
            //var teacher = await _context.Teachers.FindAsync(id);

            //if (teacher == null)
            //{
            //    return NotFound();
            //}

            //return teacher;
            var res = await _teacherService.GetTeacherByIdAsync(id);

            if (res == null)
            {
                return NotFound();
            }

            return Ok(res);
        }

        //[HttpGet("{id}")]
        //[Route("~/api/Teachers/{teacherId:int}/Students")]
        //public async Task<ActionResult<StudentDTO>> GetStudentsByTeacherId(int teacherId)
        //{
        //    var res = await _studentService.GetStudentsByTeacherAsync(teacherId);

        //    if (res == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(res);
        //}

        [HttpGet("{id}")]
        [Route("~/api/Teachers/{teacherId:int}/Tests")]
        public async Task<ActionResult<TestDTO>> GetTestsByTeacherId(int teacherId)
        {
            var res = await _testService.GetTestsByTeacherAsync(teacherId);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        //  // PUT: api/Teachers/5
        //  // To protect from overposting attacks, enable the specific properties you want to bind to, for
        //  // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //  [HttpPut("{id}")]
        //  public async Task<IActionResult> PutTeacher(int id, Teacher teacher)
        //  {
        //      if (id != teacher.Id)
        //      {
        //          return BadRequest();
        //      }

        //      //_context.Entry(teacher).State = EntityState.Modified;

        //      try
        //      {
        ////          await _context.SaveChangesAsync();
        //      }
        //      catch (DbUpdateConcurrencyException)
        //      {
        //          if (!TeacherExists(id))
        //          {
        //              return NotFound();
        //          }
        //          else
        //          {
        //              throw;
        //          }
        //      }

        //      throw new NotImplementedException();
        //      return NoContent();
        //  }

        // POST: api/Teachers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<Teacher>> PostTeacher(Teacher teacher)
        //{
        //    _context.Teachers.Add(teacher);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetTeacher", new { id = teacher.Id }, teacher);
        //}

        //// DELETE: api/Teachers/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Teacher>> DeleteTeacher(int id)
        //{
        //    var teacher = await _context.Teachers.FindAsync(id);
        //    if (teacher == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Teachers.Remove(teacher);
        //    await _context.SaveChangesAsync();

        //    return teacher;
        //}

        //private bool TeacherExists(int id)
        //{ 
        //    return _context.Teachers.Any(e => e.Id == id);
        //}
    }
}