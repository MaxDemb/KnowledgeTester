using System;
using System.Collections.Generic;
using System.Text;
using DAL.EntityFramework.Repositories.Generic;
using DAL.Interfaces.Repositories;
using DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;

namespace DAL.EntityFramework.Repositories
{
    public class ResultRepository : GenericRepository<Result>, IResultRepository
    {
        public ResultRepository(ApiAuthorizationDbContext<ApplicationUser> context) : base(context)
        {
        }

        protected override IQueryable<Result> DbSetWithAllProperties()
        {
            return DbSet;
        }
    }
}
