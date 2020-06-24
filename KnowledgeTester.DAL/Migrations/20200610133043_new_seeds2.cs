using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.EntityFramework.Migrations
{
    public partial class new_seeds2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 13, 52, 303, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 13, 52, 307, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 13, 52, 307, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 13, 52, 307, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 13, 52, 307, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 13, 52, 307, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 13, 52, 307, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 13, 52, 307, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 13, 52, 307, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 10, 16, 13, 52, 307, DateTimeKind.Local).AddTicks(5071));
        }
    }
}
