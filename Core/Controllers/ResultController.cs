using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {

        private readonly IResultService _resultService;
        public ResultController(IResultService resultService)
        {
            this._resultService = resultService;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<ResultDTO>> AddResult(ResultDTO model)
        {
            return await _resultService.AddResultAsync(model);
        }

        [HttpPut]
        [Route("Update")]
        public async Task UpdateResult(ResultDTO model)
        {
            _resultService.UpdateResultAsync(model);
        }

        [HttpPost]
        [Route("Exist")]
        public async Task<ActionResult<ResultDTO>> ExistResult(ResultDTO model)
        {
            return await _resultService.ResultExist(model);
        }


    }
}
