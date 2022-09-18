using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class ApplicationUserChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "User",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "User",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);
        }
    }
}
