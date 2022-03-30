using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemorabiliaManager.Data.Migrations
{
	public partial class ItemFKFix : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			//migrationBuilder.DropForeignKey(
			//	name: "FK_Items_Signatures_SignatureId",
			//	table: "Items");

			//migrationBuilder.DropIndex(
			//	name: "IX_Items_SignatureId",
			//	table: "Items");

			//migrationBuilder.DropColumn(
			//	name: "SignatureId",
			//	table: "Items");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<int>(
				name: "SignatureId",
				table: "Items",
				type: "int",
				nullable: true);

			migrationBuilder.CreateIndex(
				name: "IX_Items_SignatureId",
				table: "Items",
				column: "SignatureId");

			migrationBuilder.AddForeignKey(
				name: "FK_Items_Signatures_SignatureId",
				table: "Items",
				column: "SignatureId",
				principalTable: "Signatures",
				principalColumn: "Id");
		}
	}
}
