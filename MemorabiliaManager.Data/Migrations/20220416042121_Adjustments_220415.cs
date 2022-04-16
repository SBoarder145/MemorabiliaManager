using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemorabiliaManager.Data.Migrations
{
    public partial class Adjustments_220415 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ItemCategories",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "IsSportTeam",
                table: "Entertainment",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSportTeam",
                table: "Entertainment");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ItemCategories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
