using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretApp_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CategoryUpdate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategeoryId",
                table: "CategoryProperties");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategeoryId",
                table: "CategoryProperties",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
