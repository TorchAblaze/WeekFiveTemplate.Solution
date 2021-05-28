using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekFourTemplate.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TemplateCategories",
                columns: table => new
                {
                    TemplateCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SomeProperty = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateCategories", x => x.TemplateCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "TemplateItems",
                columns: table => new
                {
                    TemplateItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SomeProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateItems", x => x.TemplateItemId);
                });

            migrationBuilder.CreateTable(
                name: "TemplateCategoryItem",
                columns: table => new
                {
                    TemplateCategoryItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TemplateItemId = table.Column<int>(type: "int", nullable: false),
                    TemplateCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateCategoryItem", x => x.TemplateCategoryItemId);
                    table.ForeignKey(
                        name: "FK_TemplateCategoryItem_TemplateCategories_TemplateCategoryId",
                        column: x => x.TemplateCategoryId,
                        principalTable: "TemplateCategories",
                        principalColumn: "TemplateCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TemplateCategoryItem_TemplateItems_TemplateItemId",
                        column: x => x.TemplateItemId,
                        principalTable: "TemplateItems",
                        principalColumn: "TemplateItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TemplateCategoryItem_TemplateCategoryId",
                table: "TemplateCategoryItem",
                column: "TemplateCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateCategoryItem_TemplateItemId",
                table: "TemplateCategoryItem",
                column: "TemplateItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TemplateCategoryItem");

            migrationBuilder.DropTable(
                name: "TemplateCategories");

            migrationBuilder.DropTable(
                name: "TemplateItems");
        }
    }
}
