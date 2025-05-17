using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademyShop.Migrations
{
    /// <inheritdoc />
    public partial class updatenew2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_CategoriesId1",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_CategoriesId1",
                table: "products");

            migrationBuilder.DropColumn(
                name: "CategoriesId1",
                table: "products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriesId1",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoriesId1",
                table: "products",
                column: "CategoriesId1");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_CategoriesId1",
                table: "products",
                column: "CategoriesId1",
                principalTable: "categories",
                principalColumn: "Id");
        }
    }
}
