using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskofMay19.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductDescription",
                table: "Product",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Product",
                newName: "ProductDescription");
        }
    }
}
