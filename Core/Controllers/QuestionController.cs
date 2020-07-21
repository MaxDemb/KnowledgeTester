using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;

namespace Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {

        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            this._questionService = questionService;
        }

        [HttpGet]
        [Route("~/api/Questions/getByTestId/{id}")]
        public async Task<ActionResult<IEnumerable<QuestionDTO>>> getQuestionsByTestId(int id)
        {
            var res = await _questionService.GetQuestionsByTestId(id);
            if(res != null)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }


        [HttpPost]
        [Route("new")]
        //POST : /api/Question/new
        public async Task<ActionResult<QuestionDTO>> addQuestion(QuestionDTO questionModel)
        {

            return await _questionService.AddQuestionAsync(questionModel);
        }
    }
}
