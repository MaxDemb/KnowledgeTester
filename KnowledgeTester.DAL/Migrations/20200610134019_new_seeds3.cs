using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.EntityFramework.Migrations
{
    public partial class new_seeds3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "IsActive", "Name", "ProfileImagePath", "RegistrationDate", "TeacherId" },
                values: new object[,]
                {
                    { 1, 18, true, "Max Dembitsky", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(1371), 1 },
                    { 22, 65, true, "Shadow", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3989), 2 },
                    { 21, 25, true, "Michael Jackson", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3980), 6 },
                    { 20, 63, true, "Fredie", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3973), 8 },
                    { 19, 27, true, "Elon Musk", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3966), 10 },
                    { 18, 53, true, "Isaac Newton", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3959), 10 },
                    { 17, 22, true, "Morgenshetrn", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3952), 8 },
                    { 15, 56, true, "Limba", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3938), 7 },
                    { 14, 32, true, "Somebody new", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3931), 6 },
                    { 13, 43, true, "Interrest", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3924), 5 },
                    { 12, 56, false, "Max Term", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3917), 5 },
                    { 16, 63, true, "Andro", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3945), 7 },
                    { 10, 62, true, "Sofia", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3904), 4 },
                    { 11, 15, true, "Kate", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3910), 4 },
                    { 3, 26, true, "Mike Vazovsky", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3854), 1 },
                    { 4, 23, true, "Keis Lokie", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3863), 1 },
                    { 5, 15, true, "Petro", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3870), 2 },
                    { 2, 16, true, "Ivan Gal", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3783), 1 },
                    { 7, 29, false, "Svitlana", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3883), 2 },
                    { 8, 56, true, "Murko", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3890), 3 },
                    { 9, 21, true, "Taras", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3897), 3 },
                    { 6, 29, true, "Olga", null, new DateTime(2020, 6, 10, 16, 40, 18, 661, DateTimeKind.Local).AddTicks(3877), 2 }
                });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 40, 18, 649, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 40, 18, 655, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 40, 18, 655, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 40, 18, 655, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 40, 18, 655, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 40, 18, 655, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 40, 18, 655, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 40, 18, 655, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 40, 18, 655, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 40, 18, 655, DateTimeKind.Local).AddTicks(7815));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 30, 42, 690, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 30, 42, 694, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 30, 42, 694, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 30, 42, 694, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 30, 42, 694, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 30, 42, 694, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 30, 42, 694, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 30, 42, 694, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 30, 42, 694, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 30, 42, 694, DateTimeKind.Local).AddTicks(4752));
        }
    }
}
