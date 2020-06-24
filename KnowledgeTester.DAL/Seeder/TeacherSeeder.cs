using DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EntityFramework.Seeder
{
    public static class TeacherSeeder
    {
        public static void SeedDatabase(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Teacher>().HasData(
                new Teacher
                {
                    Id = 1,
                    Name = "Frank",
                    Age = 21,
                    IsActive = true,
                    RegistrationDate = DateTime.Now
                },
                new Teacher
                {
                    Id = 2,
                    Name = "James",
                    Age = 25,
                    IsActive = true,
                    RegistrationDate = DateTime.Now
                },
                new Teacher
                {
                    Id = 3,
                    Name = "Olga",
                    Age = 34,
                    IsActive = true,
                    RegistrationDate = DateTime.Now
                },
                new Teacher
                {
                    Id = 4,
                    Name = "Ocean",
                    Age = 35,
                    IsActive = true,
                    RegistrationDate = DateTime.Now
                },
                new Teacher
                {
                    Id = 5,
                    Name = "Kate",
                    Age = 28,
                    IsActive = true,
                    RegistrationDate = DateTime.Now
                },
                new Teacher
                {
                    Id = 6,
                    Name = "Harold",
                    Age = 40,
                    IsActive = true,
                    RegistrationDate = DateTime.Now
                },
                new Teacher
                {
                    Id = 7,
                    Name = "Harold Cat",
                    Age = 40,
                    IsActive = true,
                    RegistrationDate = DateTime.Now
                },
                new Teacher
                {
                    Id = 8,
                    Name = "Tom Hard",
                    Age = 44,
                    IsActive = true,
                    RegistrationDate = DateTime.Now
                },
                new Teacher
                {
                    Id = 9,
                    Name = "Sinatra",
                    Age = 42,
                    IsActive = true,
                    RegistrationDate = DateTime.Now
                },
                new Teacher
                {
                    Id = 10,
                    Name = "Dima",
                    Age = 56,
                    IsActive = true,
                    RegistrationDate = DateTime.Now
                }
            );

        }
    }
}
