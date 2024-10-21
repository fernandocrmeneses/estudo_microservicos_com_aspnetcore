using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CmsProject.Templates.Infrastructure.Migrations
{
    public partial class migration_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CSS_Historico_HistoricoCssFileId",
                table: "CSS");

            migrationBuilder.DropForeignKey(
                name: "FK_Paginas_Historico_HistoricoPaginaId",
                table: "Paginas");

            migrationBuilder.DropTable(
                name: "Historico");

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuario",
                table: "Paginas",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "HistoricoPorPagina",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    IdPagina = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoPorPagina", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CSS_HistoricoPorPagina_HistoricoCssFileId",
                table: "CSS",
                column: "HistoricoCssFileId",
                principalTable: "HistoricoPorPagina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Paginas_HistoricoPorPagina_HistoricoPaginaId",
                table: "Paginas",
                column: "HistoricoPaginaId",
                principalTable: "HistoricoPorPagina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CSS_HistoricoPorPagina_HistoricoCssFileId",
                table: "CSS");

            migrationBuilder.DropForeignKey(
                name: "FK_Paginas_HistoricoPorPagina_HistoricoPaginaId",
                table: "Paginas");

            migrationBuilder.DropTable(
                name: "HistoricoPorPagina");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Paginas");

            migrationBuilder.CreateTable(
                name: "Historico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataHistorico = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdBackup = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historico", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CSS_Historico_HistoricoCssFileId",
                table: "CSS",
                column: "HistoricoCssFileId",
                principalTable: "Historico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Paginas_Historico_HistoricoPaginaId",
                table: "Paginas",
                column: "HistoricoPaginaId",
                principalTable: "Historico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
