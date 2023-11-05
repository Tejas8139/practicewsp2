using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBooks.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetup1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "category1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_category1",
                table: "category1",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_category1",
                table: "category1");

            migrationBuilder.RenameTable(
                name: "category1",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");
        }
    }
}
