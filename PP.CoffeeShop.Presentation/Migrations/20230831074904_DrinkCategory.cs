using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PP.CoffeeShop.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class DrinkCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Drinks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DrinkCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinkCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_CategoryId",
                table: "Drinks",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drinks_DrinkCategories_CategoryId",
                table: "Drinks",
                column: "CategoryId",
                principalTable: "DrinkCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drinks_DrinkCategories_CategoryId",
                table: "Drinks");

            migrationBuilder.DropTable(
                name: "DrinkCategories");

            migrationBuilder.DropIndex(
                name: "IX_Drinks_CategoryId",
                table: "Drinks");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Drinks");
        }
    }
}
