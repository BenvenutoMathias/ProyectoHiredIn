using Microsoft.EntityFrameworkCore.Migrations;

namespace EspacioNube.web.Migrations
{
    public partial class CambiosEnConsultar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Postulantes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Postulantes");
        }
    }
}
