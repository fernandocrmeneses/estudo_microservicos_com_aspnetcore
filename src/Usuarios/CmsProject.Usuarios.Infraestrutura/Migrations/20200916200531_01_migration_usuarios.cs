using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CmsProject.Usuarios.Infraestrutura.Migrations
{
    public partial class _01_migration_usuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios_system",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    nome = table.Column<string>(type: "varchar(255)", nullable: false),
                    sobrenome = table.Column<string>(type: "varchar(255)", nullable: false),
                    cpf_cnpj = table.Column<string>(type: "varchar(50)", nullable: false),
                    ativo = table.Column<sbyte>(type: "tinyint", nullable: false),
                    status = table.Column<string>(type: "varchar(50)", nullable: true),
                    dataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    dataCancelamento = table.Column<DateTime>(type: "datetime", nullable: false),
                    dataRetorno = table.Column<DateTime>(type: "datetime", nullable: false),
                    tipoUsuario = table.Column<int>(type: "int", nullable: false),
                    idSistema = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios_system", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios_system");
        }
    }
}
