using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Infrastructure.Services;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeTester.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {

        private readonly ITestService _testService;
        private readonly IQuestionService _questionService;
        public TestsController(ITestService testService, IQuestionService questionService)
        {
            this._testService = testService;
            this._questionService = questionService;
        }

        [HttpGet("{id}")]
        [Route("~/api/Tests/{id}/Test")]
        public async Task<ActionResult<TestDTO>> GetTest(int id)
        {
            var res = await this._testService.GetTestByIdAsync(id);

            if (res == null)
            {
                return NotFound();
            }

            return Ok(res);
        }

        [HttpGet("{id}")]
        [Route("~/api/Tests/{id}/Questions")]
        public async Task<ActionResult<QuestionDTO>> GetQuestionsByTest(int id)
        {
            var res = await this._questionService.GetQuestionsByTest(id);
            
            if (res == null)
            {
                return NotFound();
            }

            return Ok(res);
        }


        //// GET: api/Tests
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Tests/5

        //// POST: api/Tests
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Tests/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
