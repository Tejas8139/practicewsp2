using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetapp1.Migrations
{
    /// <inheritdoc />
    public partial class mgff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoriess",
                table: "Categoriess");

            migrationBuilder.RenameTable(
                name: "Categoriess",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categoriess");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoriess",
                table: "Categoriess",
                column: "Id");
        }
    }
}
