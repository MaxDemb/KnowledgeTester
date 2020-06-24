using DAL.EntityFramework.Repositories.Generic;
using DAL.Interfaces.Repositories;
using DAL.Domain.Entities;
using System.Linq;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;

namespace DAL.EntityFramework.Repositories
{
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(ApiAuthorizationDbContext<ApplicationUser> context) : base(context)
        {
        }

        protected override IQueryable<Teacher> DbSetWithAllProperties()
        {
            return DbSet;
        }
    }
}
