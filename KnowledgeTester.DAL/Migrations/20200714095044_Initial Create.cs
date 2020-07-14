using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.EntityFramework.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    ProfileImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    ProfileImagePath = table.Column<string>(nullable: true),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    OpenedDate = table.Column<DateTime>(nullable: false),
                    Deadline = table.Column<DateTime>(nullable: false),
                    IsOpen = table.Column<bool>(nullable: false),
                    OwnerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tests_Teachers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    QuestionText = table.Column<string>(nullable: true),
                    QuestionRightAnswer = table.Column<string>(nullable: true),
                    QuestionStudentAnswer = table.Column<string>(nullable: true),
                    TestId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Mark = table.Column<int>(nullable: false),
                    RightAnswers = table.Column<int>(nullable: false),
                    Passed = table.Column<bool>(nullable: false),
                    TestId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Results_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AnswerVariants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Right = table.Column<bool>(nullable: false),
                    QuestionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnswerVariants_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Age", "IsActive", "Name", "ProfileImagePath", "RegistrationDate" },
                values: new object[,]
                {
                    { 1, 21, true, "Frank", null, new DateTime(2020, 7, 14, 12, 50, 43, 893, DateTimeKind.Local).AddTicks(6672) },
                    { 2, 25, true, "James", null, new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6317) },
                    { 3, 34, true, "Olga", null, new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6426) },
                    { 4, 35, true, "Ocean", null, new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6442) },
                    { 5, 28, true, "Kate", null, new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6457) },
                    { 6, 40, true, "Harold", null, new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6473) },
                    { 7, 40, true, "Harold Cat", null, new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6488) },
                    { 8, 44, true, "Tom Hard", null, new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6502) },
                    { 9, 42, true, "Sinatra", null, new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6517) },
                    { 10, 56, true, "Dima", null, new DateTime(2020, 7, 14, 12, 50, 43, 899, DateTimeKind.Local).AddTicks(6533) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "IsActive", "Name", "ProfileImagePath", "RegistrationDate", "TeacherId" },
                values: new object[,]
                {
                    { 1, 18, true, "Max Dembitsky", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(3542), 1 },
                    { 20, 63, true, "Fredie", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6225), 8 },
                    { 17, 22, true, "Morgenshetrn", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6183), 8 },
                    { 16, 63, true, "Andro", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6167), 7 },
                    { 15, 56, true, "Limba", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6151), 7 },
                    { 21, 25, true, "Michael Jackson", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6240), 6 },
                    { 14, 32, true, "Somebody new", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6135), 6 },
                    { 13, 43, true, "Interrest", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6119), 5 },
                    { 12, 56, false, "Max Term", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6104), 5 },
                    { 18, 53, true, "Isaac Newton", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6199), 10 },
                    { 11, 15, true, "Kate", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6092), 4 },
                    { 10, 62, true, "Sofia", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6076), 4 },
                    { 9, 21, true, "Taras", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6061), 3 },
                    { 19, 27, true, "Elon Musk", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6215), 10 },
                    { 2, 16, true, "Ivan Gal", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(5934), 1 },
                    { 3, 26, true, "Mike Vazovsky", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(5990), 1 },
                    { 22, 65, true, "Shadow", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6254), 2 },
                    { 4, 23, true, "Keis Lokie", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6000), 1 },
                    { 7, 29, false, "Svitlana", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6037), 2 },
                    { 6, 29, true, "Olga", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6023), 2 },
                    { 8, 56, true, "Murko", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6046), 3 },
                    { 5, 15, true, "Petro", null, new DateTime(2020, 7, 14, 12, 50, 43, 903, DateTimeKind.Local).AddTicks(6013), 2 }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "CreationDate", "Deadline", "IsOpen", "Name", "OpenedDate", "OwnerId" },
                values: new object[,]
                {
                    { 5, new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "C# LINQ", new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Spanish", new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 1, new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "C# Essentials", new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 15, new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "French", new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 2, new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Python Essentials", new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "English a2", new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 13, new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "English b1", new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 11, new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "English a1", new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 10, new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Chemistry pro", new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 9, new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Chemistry middle", new DateTime(2018, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 8, new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Chemistry starter", new DateTime(2016, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 6, new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Mechanic test", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 3, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Python Pro", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 4, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "SQL Pro", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, new DateTime(2010, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "English b2", new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 7, new DateTime(2016, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Electric test", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerVariants_QuestionId",
                table: "AnswerVariants",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TestId",
                table: "Questions",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_StudentId",
                table: "Results",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_TestId",
                table: "Results",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeacherId",
                table: "Students",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_OwnerId",
                table: "Tests",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerVariants");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
