using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretApp_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CatgeoryUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyValues_CategoryProperties_CatgeoryPropertyId",
                table: "PropertyValues");

            migrationBuilder.RenameColumn(
                name: "CatgeoryPropertyId",
                table: "PropertyValues",
                newName: "CategoryPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyValues_CatgeoryPropertyId",
                table: "PropertyValues",
                newName: "IX_PropertyValues_CategoryPropertyId");

            migrationBuilder.RenameColumn(
                name: "MainCatgeoryId",
                table: "Categories",
                newName: "MainCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyValues_CategoryProperties_CategoryPropertyId",
                table: "PropertyValues",
                column: "CategoryPropertyId",
                principalTable: "CategoryProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyValues_CategoryProperties_CategoryPropertyId",
                table: "PropertyValues");

            migrationBuilder.RenameColumn(
                name: "CategoryPropertyId",
                table: "PropertyValues",
                newName: "CatgeoryPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyValues_CategoryPropertyId",
                table: "PropertyValues",
                newName: "IX_PropertyValues_CatgeoryPropertyId");

            migrationBuilder.RenameColumn(
                name: "MainCategoryId",
                table: "Categories",
                newName: "MainCatgeoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyValues_CategoryProperties_CatgeoryPropertyId",
                table: "PropertyValues",
                column: "CatgeoryPropertyId",
                principalTable: "CategoryProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
