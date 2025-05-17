using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademyShop.Migrations
{
    /// <inheritdoc />
    public partial class Productnew1Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "HasDiscount",
                table: "products",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Descreption",
                table: "products",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<bool>(
                name: "HasDiscount",
                table: "products",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Descreption",
                table: "products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);
        }
    }
}
