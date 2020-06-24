using DAL.Domain.Entities;
using DAL.EntityFramework.Configurations;
using DAL.EntityFramework.Seeder;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.EntityFramework.Context
{
    public class AppDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public AppDbContext(
          DbContextOptions<AppDbContext> options,
          IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }



        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<AnswerVariant> AnswerVariants { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new TestConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new ResultConfiguration());

            TeacherSeeder.SeedDatabase(modelBuilder);
            StudentSeeder.SeedDatabase(modelBuilder);
            TestSeeder.SeedDatabase(modelBuilder);
            //TeacherSeeder.SeedDatabase(modelBuilder);
        }
    }
}
