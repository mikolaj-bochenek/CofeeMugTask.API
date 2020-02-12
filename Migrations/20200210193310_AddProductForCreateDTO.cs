using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeMugTask.API.Migrations
{
    public partial class AddProductForCreateDTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductForCreateDTO",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductForCreateDTO");
        }
    }
}
