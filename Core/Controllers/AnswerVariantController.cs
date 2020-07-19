﻿using System;
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
    public class AnswerVariantController : ControllerBase
    {

        private readonly IAnswerVariantService _answerVariantService;
        public AnswerVariantController(IAnswerVariantService answerVariantService)
        {
            this._answerVariantService = answerVariantService;
        }


        [HttpPost]
        [Route("New")]
        //api/answerVariant/new
        public async Task<AnswerVariantDTO> PostTest(AnswerVariantDTO model)
        {
            return await _answerVariantService.CreateAnswerVariant(model);
        }
    }
}
