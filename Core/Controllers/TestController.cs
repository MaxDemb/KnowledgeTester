using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        private readonly ITestService _testService;
        private readonly IQuestionService _questionService;
        public TestController(ITestService testService, IQuestionService questionService)
        {
            this._testService = testService;
            this._questionService = questionService;
        }

        [HttpPost]
        [Route("New")]
        //api/test/new
        public async Task<TestDTO> PostTest(TestDTO model)
        {

            return await _testService.CreateTest(model);

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


        [HttpGet("{id}")]
        [Route("~/api/Test/all")]
        public async Task<ActionResult<QuestionDTO>> GetAllTests(int id)
        {
            var res = await this._testService.GetAllTestsAsync();

            if (res == null)
            {
                return NotFound();
            }

            return Ok(res);
        }


    }
}
