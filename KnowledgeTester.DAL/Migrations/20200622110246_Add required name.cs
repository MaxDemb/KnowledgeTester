using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.EntityFramework.Migrations
{
    public partial class Addrequiredname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tests",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teachers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Results",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AnswerVariants",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 152, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 147, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 150, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 150, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 150, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 150, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 150, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 150, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 150, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 150, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 22, 14, 2, 46, 150, DateTimeKind.Local).AddTicks(5502));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Results",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AnswerVariants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 645, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 639, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 643, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 643, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 643, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 643, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 643, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 643, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 643, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 643, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2020, 6, 21, 17, 23, 1, 643, DateTimeKind.Local).AddTicks(3531));
        }
    }
}
