using DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EntityFramework.Seeder
{
    public static class TestSeeder
    {
        public static void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().HasData(
               new Test
               {
                   Id = 1,
                   Name = "C# Essentials",
                   CreationDate = new DateTime(2018, 12, 25),
                   OpenedDate = new DateTime(2020, 05, 24),
                   Deadline = new DateTime(2020, 07, 01),
                   IsOpen = true,
                   OwnerId = 1
               },
               new Test
               {
                   Id = 2,
                   Name = "Python Essentials",
                   CreationDate = new DateTime(2018, 12, 25),
                   OpenedDate = new DateTime(2020, 06, 10),
                   Deadline = new DateTime(2020, 08, 01),
                   IsOpen = true,
                   OwnerId = 1
               },
               new Test
               {
                   Id = 3,
                   Name = "Python Pro",
                   CreationDate = new DateTime(2020, 01, 15),
                   OpenedDate = new DateTime(2020, 10, 10),
                   Deadline = new DateTime(2020, 08, 01),
                   IsOpen = false,
                   OwnerId = 2
               },
               new Test
               {
                   Id = 4,
                   Name = "SQL Pro",
                   CreationDate = new DateTime(2020, 01, 15),
                   OpenedDate = new DateTime(2020, 05, 1),
                   Deadline = new DateTime(2020, 07, 01),
                   IsOpen = true,
                   OwnerId = 2
               },
               new Test
               {
                   Id = 5,
                   Name = "C# LINQ",
                   CreationDate = new DateTime(2020, 02, 15),
                   OpenedDate = new DateTime(2020, 04, 10),
                   Deadline = new DateTime(2020, 07, 01),
                   IsOpen = true,
                   OwnerId = 3
               },
               new Test
               {
                   Id = 6,
                   Name = "Mechanic test",
                   CreationDate = new DateTime(2016, 01, 15),
                   OpenedDate = new DateTime(2020, 10, 10),
                   Deadline = new DateTime(2024, 08, 01),
                   IsOpen = true,
                   OwnerId = 4
               },
               new Test
               {
                   Id = 7,
                   Name = "Electric test",
                   CreationDate = new DateTime(2016, 01, 15),
                   OpenedDate = new DateTime(2020, 10, 10),
                   Deadline = new DateTime(2024, 08, 01),
                   IsOpen = true,
                   OwnerId = 4
               },
               new Test
               {
                   Id = 8,
                   Name = "Chemistry starter",
                   CreationDate = new DateTime(2010, 01, 15),
                   OpenedDate = new DateTime(2016, 10, 10),
                   Deadline = new DateTime(2016, 12, 01),
                   IsOpen = false,
                   OwnerId = 4
               },
               new Test
               {
                   Id = 9,
                   Name = "Chemistry middle",
                   CreationDate = new DateTime(2010, 01, 15),
                   OpenedDate = new DateTime(2018, 10, 10),
                   Deadline = new DateTime(2019, 12, 01),
                   IsOpen = false,
                   OwnerId = 4
               },
               new Test
               {
                   Id = 10,
                   Name = "Chemistry pro",
                   CreationDate = new DateTime(2010, 01, 15),
                   OpenedDate = new DateTime(2019, 10, 10),
                   Deadline = new DateTime(2020, 12, 01),
                   IsOpen = true,
                   OwnerId = 4
               },
               new Test
               {
                   Id = 11,
                   Name = "English a1",
                   CreationDate = new DateTime(2010, 01, 15),
                   OpenedDate = new DateTime(2019, 10, 10),
                   Deadline = new DateTime(2020, 12, 01),
                   IsOpen = true,
                   OwnerId = 5
               },
               new Test
               {
                   Id = 12,
                   Name = "English a2",
                   CreationDate = new DateTime(2010, 01, 15),
                   OpenedDate = new DateTime(2019, 10, 10),
                   Deadline = new DateTime(2020, 12, 01),
                   IsOpen = true,
                   OwnerId = 5
               },
               new Test
               {
                   Id = 13,
                   Name = "English b1",
                   CreationDate = new DateTime(2010, 01, 15),
                   OpenedDate = new DateTime(2019, 10, 10),
                   Deadline = new DateTime(2020, 12, 01),
                   IsOpen = true,
                   OwnerId = 5
               },
               new Test
               {
                   Id = 14,
                   Name = "English b2",
                   CreationDate = new DateTime(2010, 01, 15),
                   OpenedDate = new DateTime(2019, 10, 10),
                   Deadline = new DateTime(2020, 12, 01),
                   IsOpen = true,
                   OwnerId = 5
               },
               new Test
               {
                   Id = 15,
                   Name = "French",
                   CreationDate = new DateTime(2010, 01, 15),
                   OpenedDate = new DateTime(2019, 10, 10),
                   Deadline = new DateTime(2020, 12, 01),
                   IsOpen = true,
                   OwnerId = 6
               },
               new Test
               {
                   Id = 16,
                   Name = "Spanish",
                   CreationDate = new DateTime(2010, 01, 15),
                   OpenedDate = new DateTime(2019, 10, 10),
                   Deadline = new DateTime(2020, 12, 01),
                   IsOpen = true,
                   OwnerId = 7
               }

            ) ;
        }
    }
}
