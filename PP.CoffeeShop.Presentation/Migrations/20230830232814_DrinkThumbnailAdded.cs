using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PP.CoffeeShop.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class DrinkThumbnailAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThumbnailImageUrl",
                table: "Drinks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThumbnailImageUrl",
                table: "Drinks");
        }
    }
}
