﻿using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Domain.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public async Task<IEnumerable<AnswerVariantDTO>> getAnswerVariantsByQuestionIdAsync(int id)
        {
            var allAnswerVariants = await UnitOfWork.AnswerVariant.GetAllAsync();
            var res = allAnswerVariants.Where(x => x.QuestionId == id);
            return Mapper.Map<IEnumerable<AnswerVariant>,IEnumerable <AnswerVariantDTO>>(res);
        }

        public async Task<AnswerVariantDTO> CheckAnswerVariant(AnswerVariantDTO answerVariant)
        {
            var answerFromBack = await UnitOfWork.AnswerVariant.GetByIdAsync(answerVariant.Id);
            return Mapper.Map<AnswerVariant, AnswerVariantDTO>(answerFromBack);
        }
    }
}
