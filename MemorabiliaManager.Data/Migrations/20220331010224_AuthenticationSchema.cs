using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemorabiliaManager.Data.Migrations
{
    public partial class AuthenticationSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthenticationNumber",
                table: "Signatures");

            migrationBuilder.CreateTable(
                name: "Authentications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthenticationService = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AuthenticationCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    SignatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authentications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authentications_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Authentications_Signatures_SignatureId",
                        column: x => x.SignatureId,
                        principalTable: "Signatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authentications_ItemId",
                table: "Authentications",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Authentications_SignatureId",
                table: "Authentications",
                column: "SignatureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authentications");

            migrationBuilder.AddColumn<string>(
                name: "AuthenticationNumber",
                table: "Signatures",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);
        }
    }
}
