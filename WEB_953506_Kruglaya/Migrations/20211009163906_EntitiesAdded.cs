using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB_953506_Kruglaya.Migrations
{
    public partial class EntitiesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moovies_MooviesCategories_CategoryID",
                table: "Moovies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MooviesCategories",
                table: "MooviesCategories");

            migrationBuilder.RenameTable(
                name: "MooviesCategories",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Moovies_Categories_CategoryID",
                table: "Moovies",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moovies_Categories_CategoryID",
                table: "Moovies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "MooviesCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MooviesCategories",
                table: "MooviesCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Moovies_MooviesCategories_CategoryID",
                table: "Moovies",
                column: "CategoryID",
                principalTable: "MooviesCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
