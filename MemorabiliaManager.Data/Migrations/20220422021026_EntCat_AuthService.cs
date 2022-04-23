using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemorabiliaManager.Data.Migrations
{
	public partial class EntCat_AuthService : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "Category",
				table: "Entertainment");

			migrationBuilder.DropColumn(
				name: "AuthenticationService",
				table: "Authentications");

			migrationBuilder.AddColumn<int>(
				name: "EntertainmentCategoryId",
				table: "Entertainment",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "AuthenticationServiceId",
				table: "Authentications",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.CreateTable(
				name: "AuthenticationServices",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Website = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AuthenticationServices", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "EntertainmentCategories",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_EntertainmentCategories", x => x.Id);
				});

			migrationBuilder.CreateIndex(
				name: "IX_Entertainment_EntertainmentCategoryId",
				table: "Entertainment",
				column: "EntertainmentCategoryId");

			migrationBuilder.CreateIndex(
				name: "IX_Authentications_AuthenticationServiceId",
				table: "Authentications",
				column: "AuthenticationServiceId");

			migrationBuilder.AddForeignKey(
				name: "FK_Authentications_AuthenticationServices_AuthenticationServiceId",
				table: "Authentications",
				column: "AuthenticationServiceId",
				principalTable: "AuthenticationServices",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);

			migrationBuilder.AddForeignKey(
				name: "FK_Entertainment_EntertainmentCategories_EntertainmentCategoryId",
				table: "Entertainment",
				column: "EntertainmentCategoryId",
				principalTable: "EntertainmentCategories",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_Authentications_AuthenticationServices_AuthenticationServiceId",
				table: "Authentications");

			migrationBuilder.DropForeignKey(
				name: "FK_Entertainment_EntertainmentCategories_EntertainmentCategoryId",
				table: "Entertainment");

			migrationBuilder.DropTable(
				name: "AuthenticationServices");

			migrationBuilder.DropTable(
				name: "EntertainmentCategories");

			migrationBuilder.DropIndex(
				name: "IX_Entertainment_EntertainmentCategoryId",
				table: "Entertainment");

			migrationBuilder.DropIndex(
				name: "IX_Authentications_AuthenticationServiceId",
				table: "Authentications");

			migrationBuilder.DropColumn(
				name: "EntertainmentCategoryId",
				table: "Entertainment");

			migrationBuilder.DropColumn(
				name: "AuthenticationServiceId",
				table: "Authentications");

			migrationBuilder.AddColumn<string>(
				name: "Category",
				table: "Entertainment",
				type: "nvarchar(100)",
				maxLength: 100,
				nullable: false,
				defaultValue: "");

			migrationBuilder.AddColumn<string>(
				name: "AuthenticationService",
				table: "Authentications",
				type: "nvarchar(50)",
				maxLength: 50,
				nullable: false,
				defaultValue: "");
		}
	}
}
