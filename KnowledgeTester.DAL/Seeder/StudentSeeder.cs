using DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EntityFramework.Seeder
{
    public static class StudentSeeder
    {
        public static void SeedDatabase(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>().HasData(
            //    new Student
            //    {
            //        Id = 1,
            //        Name = "Max Dembitsky",
            //        Age = 18,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 1
            //    },
            //    new Student
            //    {

            //        Id = 2,
            //        Name = "Ivan Gal",
            //        Age = 16,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 1
            //    },
            //    new Student
            //    {

            //        Id = 3,
            //        Name = "Mike Vazovsky",
            //        Age = 26,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 1
            //    },
            //    new Student
            //    {

            //        Id = 4,
            //        Name = "Keis Lokie",
            //        Age = 23,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 1
            //    },
            //    new Student
            //    {

            //        Id = 5,
            //        Name = "Petro",
            //        Age = 15,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 2
            //    },
            //    new Student
            //    {

            //        Id = 6,
            //        Name = "Olga",
            //        Age = 29,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 2
            //    },
            //    new Student
            //    {

            //        Id = 7,
            //        Name = "Svitlana",
            //        Age = 29,
            //        IsActive = false,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 2
            //    },
            //    new Student
            //    {

            //        Id = 8,
            //        Name = "Murko",
            //        Age = 56,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 3
            //    },
            //    new Student
            //    {

            //        Id = 9,
            //        Name = "Taras",
            //        Age = 21,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 3
            //    },
            //    new Student
            //    {

            //        Id = 10,
            //        Name = "Sofia",
            //        Age = 62,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 4
            //    },
            //    new Student
            //    {

            //        Id = 11,
            //        Name = "Kate",
            //        Age = 15,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 4
            //    },
            //    new Student
            //    {

            //        Id = 12,
            //        Name = "Max Term",
            //        Age = 56,
            //        IsActive = false,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 5
            //    },
            //    new Student
            //    {

            //        Id = 13,
            //        Name = "Interrest",
            //        Age = 43,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 5
            //    },
            //    new Student
            //    {

            //        Id = 14,
            //        Name = "Somebody new",
            //        Age = 32,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 6
            //    },
            //    new Student
            //    {

            //        Id = 15,
            //        Name = "Limba",
            //        Age = 56,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 7
            //    },
            //    new Student
            //    {

            //        Id = 16,
            //        Name = "Andro",
            //        Age = 63,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 7
            //    },
            //    new Student
            //    {

            //        Id = 17,
            //        Name = "Morgenshetrn",
            //        Age = 22,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 8
            //    },
            //    new Student
            //    {

            //        Id = 18,
            //        Name = "Isaac Newton",
            //        Age = 53,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 10
            //    },
            //    new Student
            //    {

            //        Id = 19,
            //        Name = "Elon Musk",
            //        Age = 27,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 10
            //    },
            //    new Student
            //    {

            //        Id = 20,
            //        Name = "Fredie",
            //        Age = 63,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 8
            //    },
            //    new Student
            //    {

            //        Id = 21,
            //        Name = "Michael Jackson",
            //        Age = 25,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 6
            //    },
            //    new Student
            //    {

            //        Id = 22,
            //        Name = "Shadow",
            //        Age = 65,
            //        IsActive = true,
            //        RegistrationDate = DateTime.Now,
            //        TeacherId = 2
            //    });
        }
    }

}