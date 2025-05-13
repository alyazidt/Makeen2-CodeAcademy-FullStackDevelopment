using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademyShop.Migrations
{
    /// <inheritdoc />
    public partial class Tagnew2Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category_Name",
                table: "tags",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tags",
                newName: "Category_Name");
        }
    }
}
