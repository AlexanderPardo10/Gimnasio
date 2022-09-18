using Microsoft.EntityFrameworkCore.Migrations;

namespace Gym.App.Persistencia.Migrations
{
    public partial class Migraciondos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Genero",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Customers");
        }
    }
}
