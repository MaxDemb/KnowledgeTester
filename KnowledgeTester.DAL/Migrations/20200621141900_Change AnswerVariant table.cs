using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.EntityFramework.Migrations
{
    public partial class ChangeAnswerVarianttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "AnswerVariants");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AnswerVariants",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 996, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 991, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 994, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 994, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 994, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 994, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 994, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 994, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 994, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 994, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 18, 59, 994, DateTimeKind.Local).AddTicks(7407));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AnswerVariants");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "AnswerVariants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 144, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 139, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 142, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 142, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 142, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 142, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 142, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 142, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 142, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 142, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 19, 16, 57, 33, 142, DateTimeKind.Local).AddTicks(7575));
        }
    }
}
