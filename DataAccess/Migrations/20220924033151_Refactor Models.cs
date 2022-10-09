using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class RefactorModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Empresas_EmpresaID",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_PostulanteEmpresa_Empresas_EmpresasID",
                table: "PostulanteEmpresa");

            migrationBuilder.DropForeignKey(
                name: "FK_PostulanteEmpresa_Postulantes_PostulantesID",
                table: "PostulanteEmpresa");

            migrationBuilder.DropForeignKey(
                name: "FK_Postulantes_Post_PostID",
                table: "Postulantes");

            migrationBuilder.RenameColumn(
                name: "PostID",
                table: "Postulantes",
                newName: "PostId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Postulantes",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Postulantes_PostID",
                table: "Postulantes",
                newName: "IX_Postulantes_PostId");

            migrationBuilder.RenameColumn(
                name: "PostulantesID",
                table: "PostulanteEmpresa",
                newName: "PostulantesId");

            migrationBuilder.RenameColumn(
                name: "EmpresasID",
                table: "PostulanteEmpresa",
                newName: "EmpresasId");

            migrationBuilder.RenameIndex(
                name: "IX_PostulanteEmpresa_PostulantesID",
                table: "PostulanteEmpresa",
                newName: "IX_PostulanteEmpresa_PostulantesId");

            migrationBuilder.RenameColumn(
                name: "EmpresaID",
                table: "Post",
                newName: "EmpresaId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Post",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Post_EmpresaID",
                table: "Post",
                newName: "IX_Post_EmpresaId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Empresas",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Empresas_EmpresaId",
                table: "Post",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PostulanteEmpresa_Empresas_EmpresasId",
                table: "PostulanteEmpresa",
                column: "EmpresasId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostulanteEmpresa_Postulantes_PostulantesId",
                table: "PostulanteEmpresa",
                column: "PostulantesId",
                principalTable: "Postulantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postulantes_Post_PostId",
                table: "Postulantes",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Empresas_EmpresaId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_PostulanteEmpresa_Empresas_EmpresasId",
                table: "PostulanteEmpresa");

            migrationBuilder.DropForeignKey(
                name: "FK_PostulanteEmpresa_Postulantes_PostulantesId",
                table: "PostulanteEmpresa");

            migrationBuilder.DropForeignKey(
                name: "FK_Postulantes_Post_PostId",
                table: "Postulantes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Postulantes",
                newName: "PostID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Postulantes",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Postulantes_PostId",
                table: "Postulantes",
                newName: "IX_Postulantes_PostID");

            migrationBuilder.RenameColumn(
                name: "PostulantesId",
                table: "PostulanteEmpresa",
                newName: "PostulantesID");

            migrationBuilder.RenameColumn(
                name: "EmpresasId",
                table: "PostulanteEmpresa",
                newName: "EmpresasID");

            migrationBuilder.RenameIndex(
                name: "IX_PostulanteEmpresa_PostulantesId",
                table: "PostulanteEmpresa",
                newName: "IX_PostulanteEmpresa_PostulantesID");

            migrationBuilder.RenameColumn(
                name: "EmpresaId",
                table: "Post",
                newName: "EmpresaID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Post",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Post_EmpresaId",
                table: "Post",
                newName: "IX_Post_EmpresaID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Empresas",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Empresas_EmpresaID",
                table: "Post",
                column: "EmpresaID",
                principalTable: "Empresas",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PostulanteEmpresa_Empresas_EmpresasID",
                table: "PostulanteEmpresa",
                column: "EmpresasID",
                principalTable: "Empresas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostulanteEmpresa_Postulantes_PostulantesID",
                table: "PostulanteEmpresa",
                column: "PostulantesID",
                principalTable: "Postulantes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postulantes_Post_PostID",
                table: "Postulantes",
                column: "PostID",
                principalTable: "Post",
                principalColumn: "ID");
        }
    }
}
