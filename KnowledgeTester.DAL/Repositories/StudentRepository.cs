using DAL.EntityFramework.Repositories.Generic;
using DAL.Interfaces.Repositories;
using DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;

namespace DAL.EntityFramework.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApiAuthorizationDbContext<ApplicationUser> context) : base(context)
        {
        }

        protected override IQueryable<Student> DbSetWithAllProperties()
        {
            return DbSet;
        }
    }
}
