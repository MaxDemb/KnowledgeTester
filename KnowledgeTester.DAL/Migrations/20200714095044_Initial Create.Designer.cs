﻿// <auto-generated />
using System;
using DAL.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.EntityFramework.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200714095044_Initial Create")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Domain.Entities.AnswerVariant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.Property<bool>("Right")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("AnswerVariants");
                });

            modelBuilder.Entity("DAL.Domain.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionRightAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionStudentAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("DAL.Domain.Entities.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Passed")
                        .HasColumnType("bit");

                    b.Property<int>("RightAnswers")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TestId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("DAL.Domain.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 18,
                            IsActive = true,
                            Name = "Max Dembitsky",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(3542),
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 2,
                            Age = 16,
                            IsActive = true,
                            Name = "Ivan Gal",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(5934),
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 3,
                            Age = 26,
                            IsActive = true,
                            Name = "Mike Vazovsky",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(5990),
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 4,
                            Age = 23,
                            IsActive = true,
                            Name = "Keis Lokie",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6000),
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 5,
                            Age = 15,
                            IsActive = true,
                            Name = "Petro",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6013),
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 6,
                            Age = 29,
                            IsActive = true,
                            Name = "Olga",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6023),
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 7,
                            Age = 29,
                            IsActive = false,
                            Name = "Svitlana",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6037),
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 8,
                            Age = 56,
                            IsActive = true,
                            Name = "Murko",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6046),
                            TeacherId = 3
                        },
                        new
                        {
                            Id = 9,
                            Age = 21,
                            IsActive = true,
                            Name = "Taras",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6061),
                            TeacherId = 3
                        },
                        new
                        {
                            Id = 10,
                            Age = 62,
                            IsActive = true,
                            Name = "Sofia",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6076),
                            TeacherId = 4
                        },
                        new
                        {
                            Id = 11,
                            Age = 15,
                            IsActive = true,
                            Name = "Kate",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6092),
                            TeacherId = 4
                        },
                        new
                        {
                            Id = 12,
                            Age = 56,
                            IsActive = false,
                            Name = "Max Term",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6104),
                            TeacherId = 5
                        },
                        new
                        {
                            Id = 13,
                            Age = 43,
                            IsActive = true,
                            Name = "Interrest",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6119),
                            TeacherId = 5
                        },
                        new
                        {
                            Id = 14,
                            Age = 32,
                            IsActive = true,
                            Name = "Somebody new",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6135),
                            TeacherId = 6
                        },
                        new
                        {
                            Id = 15,
                            Age = 56,
                            IsActive = true,
                            Name = "Limba",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6151),
                            TeacherId = 7
                        },
                        new
                        {
                            Id = 16,
                            Age = 63,
                            IsActive = true,
                            Name = "Andro",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6167),
                            TeacherId = 7
                        },
                        new
                        {
                            Id = 17,
                            Age = 22,
                            IsActive = true,
                            Name = "Morgenshetrn",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6183),
                            TeacherId = 8
                        },
                        new
                        {
                            Id = 18,
                            Age = 53,
                            IsActive = true,
                            Name = "Isaac Newton",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6199),
                            TeacherId = 10
                        },
                        new
                        {
                            Id = 19,
                            Age = 27,
                            IsActive = true,
                            Name = "Elon Musk",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6215),
                            TeacherId = 10
                        },
                        new
                        {
                            Id = 20,
                            Age = 63,
                            IsActive = true,
                            Name = "Fredie",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6225),
                            TeacherId = 8
                        },
                        new
                        {
                            Id = 21,
                            Age = 25,
                            IsActive = true,
                            Name = "Michael Jackson",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6240),
                            TeacherId = 6
                        },
                        new
                        {
                            Id = 22,
                            Age = 65,
                            IsActive = true,
                            Name = "Shadow",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6254),
                            TeacherId = 2
                        });
                });

            modelBuilder.Entity("DAL.Domain.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 21,
                            IsActive = true,
                            Name = "Frank",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 893, DateTimeKind.Local).AddTicks(6672)
                        },
                        new
                        {
                            Id = 2,
                            Age = 25,
                            IsActive = true,
                            Name = "James",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6317)
                        },
                        new
                        {
                            Id = 3,
                            Age = 34,
                            IsActive = true,
                            Name = "Olga",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6426)
                        },
                        new
                        {
                            Id = 4,
                            Age = 35,
                            IsActive = true,
                            Name = "Ocean",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6442)
                        },
                        new
                        {
                            Id = 5,
                            Age = 28,
                            IsActive = true,
                            Name = "Kate",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6457)
                        },
                        new
                        {
                            Id = 6,
                            Age = 40,
                            IsActive = true,
                            Name = "Harold",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6473)
                        },
                        new
                        {
                            Id = 7,
                            Age = 40,
                            IsActive = true,
                            Name = "Harold Cat",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6488)
                        },
                        new
                        {
                            Id = 8,
                            Age = 44,
                            IsActive = true,
                            Name = "Tom Hard",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6502)
                        },
                        new
                        {
                            Id = 9,
                            Age = 42,
                            IsActive = true,
                            Name = "Sinatra",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6517)
                        },
                        new
                        {
                            Id = 10,
                            Age = 56,
                            IsActive = true,
                            Name = "Dima",
                            RegistrationDate = new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6533)
                        });
                });

            modelBuilder.Entity("DAL.Domain.Entities.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpenedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Tests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = true,
                            Name = "C# Essentials",
                            OpenedDate = new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = true,
                            Name = "Python Essentials",
                            OpenedDate = new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = false,
                            Name = "Python Pro",
                            OpenedDate = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 2
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = true,
                            Name = "SQL Pro",
                            OpenedDate = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 2
                        },
                        new
                        {
                            Id = 5,
                            CreationDate = new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = true,
                            Name = "C# LINQ",
                            OpenedDate = new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 3
                        },
                        new
                        {
                            Id = 6,
                            CreationDate = new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = true,
                            Name = "Mechanic test",
                            OpenedDate = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 4
                        },
                        new
                        {
                            Id = 7,
                            CreationDate = new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = true,
                            Name = "Electric test",
                            OpenedDate = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 4
                        },
                        new
                        {
                            Id = 8,
                            CreationDate = new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2016, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = false,
                            Name = "Chemistry starter",
                            OpenedDate = new DateTime(2016, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 4
                        },
                        new
                        {
                            Id = 9,
                            CreationDate = new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = false,
                            Name = "Chemistry middle",
                            OpenedDate = new DateTime(2018, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 4
                        },
                        new
                        {
                            Id = 10,
                            CreationDate = new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = true,
                            Name = "Chemistry pro",
                            OpenedDate = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 4
                        },
                        new
                        {
                            Id = 11,
                            CreationDate = new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = true,
                            Name = "English a1",
                            OpenedDate = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 5
                        },
                        new
                        {
                            Id = 12,
                            CreationDate = new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = true,
                            Name = "English a2",
                            OpenedDate = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 5
                        },
                        new
                        {
                            Id = 13,
                            CreationDate = new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = true,
                            Name = "English b1",
                            OpenedDate = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 5
                        },
                        new
                        {
                            Id = 14,
                            CreationDate = new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = true,
                            Name = "English b2",
                            OpenedDate = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 5
                        },
                        new
                        {
                            Id = 15,
                            CreationDate = new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = true,
                            Name = "French",
                            OpenedDate = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 6
                        },
                        new
                        {
                            Id = 16,
                            CreationDate = new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadline = new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsOpen = true,
                            Name = "Spanish",
                            OpenedDate = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = 7
                        });
                });

            modelBuilder.Entity("DAL.Domain.Entities.AnswerVariant", b =>
                {
                    b.HasOne("DAL.Domain.Entities.Question", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("DAL.Domain.Entities.Question", b =>
                {
                    b.HasOne("DAL.Domain.Entities.Test", null)
                        .WithMany("Questions")
                        .HasForeignKey("TestId");
                });

            modelBuilder.Entity("DAL.Domain.Entities.Result", b =>
                {
                    b.HasOne("DAL.Domain.Entities.Student", "Student")
                        .WithMany("Results")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DAL.Domain.Entities.Test", "Test")
                        .WithMany("Results")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Domain.Entities.Student", b =>
                {
                    b.HasOne("DAL.Domain.Entities.Teacher", "Teachers")
                        .WithMany("Students")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Domain.Entities.Test", b =>
                {
                    b.HasOne("DAL.Domain.Entities.Teacher", "Owner")
                        .WithMany("Tests")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}