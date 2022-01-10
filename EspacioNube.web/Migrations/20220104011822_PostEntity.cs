using Microsoft.EntityFrameworkCore.Migrations;

namespace EspacioNube.web.Migrations
{
    public partial class PostEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostID",
                table: "Postulantes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderPost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyPost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpresaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Post_Empresas_EmpresaID",
                        column: x => x.EmpresaID,
                        principalTable: "Empresas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Postulantes_PostID",
                table: "Postulantes",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_EmpresaID",
                table: "Post",
                column: "EmpresaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Postulantes_Post_PostID",
                table: "Postulantes",
                column: "PostID",
                principalTable: "Post",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postulantes_Post_PostID",
                table: "Postulantes");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Postulantes_PostID",
                table: "Postulantes");

            migrationBuilder.DropColumn(
                name: "PostID",
                table: "Postulantes");
        }
    }
}
