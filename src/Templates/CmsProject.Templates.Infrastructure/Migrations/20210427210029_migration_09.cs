using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CmsProject.Templates.Infrastructure.Migrations
{
    public partial class migration_09 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPagina",
                table: "Imagens");

            migrationBuilder.AddColumn<string>(
                name: "Conteudo",
                table: "Imagens",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EhArquivoFisico",
                table: "Imagens",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Conteudo",
                table: "ElementoFrontEnd",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conteudo",
                table: "Imagens");

            migrationBuilder.DropColumn(
                name: "EhArquivoFisico",
                table: "Imagens");

            migrationBuilder.DropColumn(
                name: "Conteudo",
                table: "ElementoFrontEnd");

            migrationBuilder.AddColumn<Guid>(
                name: "IdPagina",
                table: "Imagens",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
