using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PP.CoffeeShop.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class WhatsChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drinks_DrinkCategories_CategoryId",
                table: "Drinks");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Drinks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Drinks_DrinkCategories_CategoryId",
                table: "Drinks",
                column: "CategoryId",
                principalTable: "DrinkCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drinks_DrinkCategories_CategoryId",
                table: "Drinks");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Drinks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Drinks_DrinkCategories_CategoryId",
                table: "Drinks",
                column: "CategoryId",
                principalTable: "DrinkCategories",
                principalColumn: "Id");
        }
    }
}
