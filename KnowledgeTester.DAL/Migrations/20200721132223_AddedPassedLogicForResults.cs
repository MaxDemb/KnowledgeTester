using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.EntityFramework.Migrations
{
    public partial class AddedPassedLogicForResults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Passed",
                table: "Results",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Passed",
                table: "Results");
        }
    }
}
