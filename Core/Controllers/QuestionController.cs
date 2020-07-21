using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using Core.Models;
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
        private readonly IMapper _mapper;

        public QuestionController(IQuestionService questionService, IMapper mapper)
        {
            this._questionService = questionService;
            this._mapper = mapper;
        }

        [HttpGet]
        [Route("~/api/Questions/getByTestId/{id}")]
        public async Task<ActionResult<IEnumerable<QuestionDTO>>> getQuestionsByTestId(int id)
        {
            var res = await _questionService.GetQuestionsByTestId(id);
            if(res == null)
            {
                return BadRequest(res);
            }
            var resSecure = _mapper.Map<IEnumerable<QuestionDTO>, IEnumerable<QuestionSecureModel>>(res);
            return Ok(resSecure);
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
