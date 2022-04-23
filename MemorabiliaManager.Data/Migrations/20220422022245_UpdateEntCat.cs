using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemorabiliaManager.Data.Migrations
{
    public partial class UpdateEntCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSportTeam",
                table: "Entertainment");

            migrationBuilder.AddColumn<bool>(
                name: "IsSport",
                table: "EntertainmentCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSport",
                table: "EntertainmentCategories");

            migrationBuilder.AddColumn<bool>(
                name: "IsSportTeam",
                table: "Entertainment",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
