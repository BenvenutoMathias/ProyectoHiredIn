using Microsoft.EntityFrameworkCore.Migrations;

namespace EspacioNube.web.Migrations
{
    public partial class DataProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "Foto",
                table: "User",
                newName: "Photo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "User",
                newName: "Foto");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
