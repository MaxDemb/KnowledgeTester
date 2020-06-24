using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Domain.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Infrastructure.Services
{
    public class AnswerVariantService : BaseService, IAnswerVariantService
    {

        public AnswerVariantService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {


        }

        public async Task<AnswerVariantDTO> CreateAnswerVariant(AnswerVariantDTO answerVariantDTO)
        {
            var answerVariant = Mapper.Map<AnswerVariantDTO, AnswerVariant>(answerVariantDTO);
            await UnitOfWork.AnswerVariant.CreateAsync(answerVariant);

            return answerVariantDTO;
        }
    }
}
