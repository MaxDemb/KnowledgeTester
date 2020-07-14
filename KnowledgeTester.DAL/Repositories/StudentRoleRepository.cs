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
    public class StudentRoleRepository : GenericRepository<StudentRole>, IStudentRoleRepository
    {
        public StudentRoleRepository(DbContext context) : base(context)
        {
        }

        protected override IQueryable<StudentRole> DbSetWithAllProperties()
        {
            return DbSet;
        }
    }
}
