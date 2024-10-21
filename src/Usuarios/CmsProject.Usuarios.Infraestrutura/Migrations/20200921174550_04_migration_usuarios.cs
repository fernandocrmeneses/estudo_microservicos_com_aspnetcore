using Microsoft.EntityFrameworkCore.Migrations;

namespace CmsProject.Usuarios.Infraestrutura.Migrations
{
    public partial class _04_migration_usuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios_system",
                table: "Usuarios_system");

            migrationBuilder.RenameTable(
                name: "Usuarios_system",
                newName: "Usuarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuarios_system");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios_system",
                table: "Usuarios_system",
                column: "Id");
        }
    }
}
