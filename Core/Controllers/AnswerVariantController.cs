using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerVariantController : ControllerBase
    {

        private readonly IAnswerVariantService _answerVariantService;
        private readonly IMapper _mapper;
        public AnswerVariantController(IAnswerVariantService answerVariantService, IMapper mapper)
        {
            this._answerVariantService = answerVariantService;
            this._mapper = mapper;
        }


        [HttpPost]
        [Route("New")]
        //api/answerVariant/new
        public async Task<AnswerVariantDTO> PostTest(AnswerVariantDTO model)
        {
            return await _answerVariantService.CreateAnswerVariant(model);
        }

        [HttpGet]
        [Route("~/api/answerVariant/getByQuestionId/{id}")]
        public async Task<ActionResult<IEnumerable<AnswerVariantSecureModel>>> getByQuestionId(int id)
        {
            var res = await _answerVariantService.getAnswerVariantsByQuestionIdAsync(id);
            if(res == null)
            {
                return BadRequest(res);
            }
            var resSecure = _mapper.Map<IEnumerable<AnswerVariantDTO>, IEnumerable<AnswerVariantSecureModel>>(res);
            return Ok(resSecure);
        }

        [HttpPost]
        [Route("~/api/answerVariant/Check/")]
        public async Task<ActionResult<AnswerVariantDTO>> CheckAnswerVariant(AnswerVariantSecureModel model)
        {
            var DTO = _mapper.Map<AnswerVariantSecureModel, AnswerVariantDTO>(model);
            return await _answerVariantService.CheckAnswerVariant(DTO);
        }
    }
}
