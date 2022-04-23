using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemorabiliaManager.Data.Migrations
{
    public partial class AddedNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Images");
        }
    }
}
