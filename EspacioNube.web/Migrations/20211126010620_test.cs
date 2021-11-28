using Microsoft.EntityFrameworkCore.Migrations;

namespace EspacioNube.web.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postulantes_User_FirstNameId",
                table: "Postulantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Postulantes_User_GeneroId",
                table: "Postulantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Postulantes_User_LastNameId",
                table: "Postulantes");

            migrationBuilder.DropIndex(
                name: "IX_Postulantes_FirstNameId",
                table: "Postulantes");

            migrationBuilder.DropIndex(
                name: "IX_Postulantes_GeneroId",
                table: "Postulantes");

            migrationBuilder.DropColumn(
                name: "FirstNameId",
                table: "Postulantes");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "Postulantes");

            migrationBuilder.RenameColumn(
                name: "LastNameId",
                table: "Postulantes",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Postulantes_LastNameId",
                table: "Postulantes",
                newName: "IX_Postulantes_UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Postulantes_User_UsuarioId",
                table: "Postulantes",
                column: "UsuarioId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postulantes_User_UsuarioId",
                table: "Postulantes");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Postulantes",
                newName: "LastNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Postulantes_UsuarioId",
                table: "Postulantes",
                newName: "IX_Postulantes_LastNameId");

            migrationBuilder.AddColumn<string>(
                name: "FirstNameId",
                table: "Postulantes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GeneroId",
                table: "Postulantes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Postulantes_FirstNameId",
                table: "Postulantes",
                column: "FirstNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Postulantes_GeneroId",
                table: "Postulantes",
                column: "GeneroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Postulantes_User_FirstNameId",
                table: "Postulantes",
                column: "FirstNameId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Postulantes_User_GeneroId",
                table: "Postulantes",
                column: "GeneroId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Postulantes_User_LastNameId",
                table: "Postulantes",
                column: "LastNameId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
