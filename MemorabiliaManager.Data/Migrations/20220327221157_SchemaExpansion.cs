using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemorabiliaManager.Data.Migrations
{
	public partial class SchemaExpansion : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "PlayerItems");

			migrationBuilder.DropTable(
				name: "Players");

			migrationBuilder.DropTable(
				name: "Teams");

			migrationBuilder.DropTable(
				name: "Leagues");

			migrationBuilder.AddColumn<int>(
				name: "EntertainmentId",
				table: "Items",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<string>(
				name: "ItemCollectionNumber",
				table: "Items",
				type: "nvarchar(50)",
				nullable: true);

			migrationBuilder.AddColumn<int>(
				name: "SignatureId",
				table: "Items",
				type: "int",
				nullable: true);

			migrationBuilder.CreateTable(
				name: "EntertainmentCategories",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(15)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_EntertainmentCategories", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Images",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					FileName = table.Column<string>(type: "nvarchar(100)", nullable: false),
					ByteArray = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Images", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Entertainment",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
					EntertainmentCategoryId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Entertainment", x => x.Id);
					table.ForeignKey(
						name: "FK_Entertainment_EntertainmentCategories_EntertainmentCategoryId",
						column: x => x.EntertainmentCategoryId,
						principalTable: "EntertainmentCategories",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "ItemImage",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					ItemId = table.Column<int>(type: "int", nullable: false),
					ImageId = table.Column<int>(type: "int", nullable: false)
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
				name: "Signatures",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					FirstName = table.Column<string>(type: "nvarchar(15)", nullable: false),
					LastName = table.Column<string>(type: "nvarchar(20)", nullable: false),
					EntertainmentId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Signatures", x => x.Id);
					table.ForeignKey(
						name: "FK_Signatures_Entertainment_EntertainmentId",
						column: x => x.EntertainmentId,
						principalTable: "Entertainment",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "Subjects",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
					EntertainmentId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Subjects", x => x.Id);
					table.ForeignKey(
						name: "FK_Subjects_Entertainment_EntertainmentId",
						column: x => x.EntertainmentId,
						principalTable: "Entertainment",
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
				name: "JerseyNumbers",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Number = table.Column<short>(type: "smallint", nullable: false),
					SignatureId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_JerseyNumbers", x => x.Id);
					table.ForeignKey(
						name: "FK_JerseyNumbers_Signatures_SignatureId",
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
				name: "IX_Items_EntertainmentId",
				table: "Items",
				column: "EntertainmentId");

			migrationBuilder.CreateIndex(
				name: "IX_Items_SignatureId",
				table: "Items",
				column: "SignatureId");

			migrationBuilder.CreateIndex(
				name: "IX_Entertainment_EntertainmentCategoryId",
				table: "Entertainment",
				column: "EntertainmentCategoryId");

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

			migrationBuilder.CreateIndex(
				name: "IX_JerseyNumbers_SignatureId",
				table: "JerseyNumbers",
				column: "SignatureId",
				unique: true);

			migrationBuilder.CreateIndex(
				name: "IX_Signatures_EntertainmentId",
				table: "Signatures",
				column: "EntertainmentId");

			migrationBuilder.CreateIndex(
				name: "IX_Subjects_EntertainmentId",
				table: "Subjects",
				column: "EntertainmentId");

			migrationBuilder.AddForeignKey(
				name: "FK_Items_Entertainment_EntertainmentId",
				table: "Items",
				column: "EntertainmentId",
				principalTable: "Entertainment",
				principalColumn: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_Items_Signatures_SignatureId",
				table: "Items",
				column: "SignatureId",
				principalTable: "Signatures",
				principalColumn: "Id");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_Items_Entertainment_EntertainmentId",
				table: "Items");

			migrationBuilder.DropForeignKey(
				name: "FK_Items_Signatures_SignatureId",
				table: "Items");

			migrationBuilder.DropTable(
				name: "ItemImage");

			migrationBuilder.DropTable(
				name: "ItemSignatures");

			migrationBuilder.DropTable(
				name: "ItemSubjects");

			migrationBuilder.DropTable(
				name: "JerseyNumbers");

			migrationBuilder.DropTable(
				name: "Images");

			migrationBuilder.DropTable(
				name: "Subjects");

			migrationBuilder.DropTable(
				name: "Signatures");

			migrationBuilder.DropTable(
				name: "Entertainment");

			migrationBuilder.DropTable(
				name: "EntertainmentCategories");

			migrationBuilder.DropIndex(
				name: "IX_Items_EntertainmentId",
				table: "Items");

			migrationBuilder.DropIndex(
				name: "IX_Items_SignatureId",
				table: "Items");

			migrationBuilder.DropColumn(
				name: "EntertainmentId",
				table: "Items");

			migrationBuilder.DropColumn(
				name: "ItemCollectionNumber",
				table: "Items");

			migrationBuilder.DropColumn(
				name: "SignatureId",
				table: "Items");
		}
	}
}