using DAL.Domain.Entities;
using DAL.EntityFramework.Repositories.Generic;
using DAL.Interfaces.Repositories;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace DAL.EntityFramework.Repositories
{
    class AnswerVariantRepository: GenericRepository<AnswerVariant>, IAnswerVariantRepository
    {
        public AnswerVariantRepository(DbContext context) : base(context)
        {
        }

        protected override IQueryable<AnswerVariant> DbSetWithAllProperties()
        {
            return DbSet;
        }
    }
}
