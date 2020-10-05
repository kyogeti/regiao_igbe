using Microsoft.EntityFrameworkCore.Migrations;

namespace RegiaoIbge.App.Migrations
{
    public partial class Uf2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Uf",
                table: "Cidades",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Uf",
                table: "Cidades",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
