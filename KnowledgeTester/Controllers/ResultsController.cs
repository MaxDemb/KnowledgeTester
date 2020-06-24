using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeTester.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsController : ControllerBase
    {
        private readonly IResultService _resultService;
        public ResultsController(IResultService resultService)
        {
            this._resultService = resultService;
        }

        [HttpGet("{id}")]
        [Route("~/api/Students/{studentId}/Results/{testId}/")]
        public async Task<ActionResult<bool>> GetPassedBoolByStudentAsync(int studentId, int testId)
        {
            bool res = await this._resultService.GetPassedBoolByStudentAsync(studentId, testId);


            return Ok(res);
        }
    }
}
