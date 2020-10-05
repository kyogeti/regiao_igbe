using Microsoft.EntityFrameworkCore.Migrations;

namespace RegiaoIbge.App.Migrations
{
    public partial class Uf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Uf",
                table: "Cidades",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uf",
                table: "Cidades");
        }
    }
}
