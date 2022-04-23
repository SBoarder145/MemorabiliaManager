using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemorabiliaManager.Data.Migrations
{
    public partial class dropHardCodedJoinTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemImage");

            migrationBuilder.DropTable(
                name: "ItemSignatures");

            migrationBuilder.DropTable(
                name: "ItemSubjects");

            migrationBuilder.CreateTable(
                name: "ImageItem",
                columns: table => new
                {
                    ImagesId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageItem", x => new { x.ImagesId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_ImageItem_Images_ImagesId",
                        column: x => x.ImagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImageItem_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemSignature",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    SignaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSignature", x => new { x.ItemsId, x.SignaturesId });
                    table.ForeignKey(
                        name: "FK_ItemSignature_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemSignature_Signatures_SignaturesId",
                        column: x => x.SignaturesId,
                        principalTable: "Signatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemSubject",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    SubjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSubject", x => new { x.ItemsId, x.SubjectsId });
                    table.ForeignKey(
                        name: "FK_ItemSubject_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemSubject_Subjects_SubjectsId",
                        column: x => x.SubjectsId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageItem_ItemsId",
                table: "ImageItem",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSignature_SignaturesId",
                table: "ItemSignature",
                column: "SignaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSubject_SubjectsId",
                table: "ItemSubject",
                column: "SubjectsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageItem");

            migrationBuilder.DropTable(
                name: "ItemSignature");

            migrationBuilder.DropTable(
                name: "ItemSubject");

            migrationBuilder.CreateTable(
                name: "ItemImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemImage_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemImage_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemSignatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    SignatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSignatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemSignatures_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemSignatures_Signatures_SignatureId",
                        column: x => x.SignatureId,
                        principalTable: "Signatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemSubjects_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemImage_ImageId",
                table: "ItemImage",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemImage_ItemId",
                table: "ItemImage",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSignatures_ItemId",
                table: "ItemSignatures",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSignatures_SignatureId",
                table: "ItemSignatures",
                column: "SignatureId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSubjects_ItemId",
                table: "ItemSubjects",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSubjects_SubjectId",
                table: "ItemSubjects",
                column: "SubjectId");
        }
    }
}
