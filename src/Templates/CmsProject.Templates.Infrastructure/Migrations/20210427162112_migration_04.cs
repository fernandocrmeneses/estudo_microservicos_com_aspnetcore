using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CmsProject.Templates.Infrastructure.Migrations
{
    public partial class migration_04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paginas_CSS_CssId",
                table: "Paginas");

            migrationBuilder.DropForeignKey(
                name: "FK_Paginas_HistoricoPorPagina_HistoricoPaginaId",
                table: "Paginas");

            migrationBuilder.DropForeignKey(
                name: "FK_Paginas_Imagens_ImagensId",
                table: "Paginas");

            migrationBuilder.DropTable(
                name: "CSS");

            migrationBuilder.DropTable(
                name: "HistoricoPorPagina");

            migrationBuilder.DropIndex(
                name: "IX_Paginas_CssId",
                table: "Paginas");

            migrationBuilder.DropIndex(
                name: "IX_Paginas_HistoricoPaginaId",
                table: "Paginas");

            migrationBuilder.DropIndex(
                name: "IX_Paginas_ImagensId",
                table: "Paginas");

            migrationBuilder.DropColumn(
                name: "CssId",
                table: "Paginas");

            migrationBuilder.DropColumn(
                name: "HistoricoPaginaId",
                table: "Paginas");

            migrationBuilder.DropColumn(
                name: "ImagensId",
                table: "Paginas");

            migrationBuilder.DropColumn(
                name: "Javascript",
                table: "Paginas");

            migrationBuilder.AddColumn<Guid>(
                name: "PaginaId",
                table: "Imagens",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BackupPagina",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    IdPagina = table.Column<Guid>(nullable: false),
                    PaginaId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackupPagina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BackupPagina_Paginas_PaginaId",
                        column: x => x.PaginaId,
                        principalTable: "Paginas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ElementoFrontEnd",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    IdPagina = table.Column<Guid>(nullable: false),
                    CaminhoArquivo = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    EhArquivoFisico = table.Column<bool>(nullable: false),
                    Workflow = table.Column<int>(nullable: false),
                    PaginaId = table.Column<Guid>(nullable: true),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementoFrontEnd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElementoFrontEnd_Paginas_PaginaId",
                        column: x => x.PaginaId,
                        principalTable: "Paginas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_PaginaId",
                table: "Imagens",
                column: "PaginaId");

            migrationBuilder.CreateIndex(
                name: "IX_BackupPagina_PaginaId",
                table: "BackupPagina",
                column: "PaginaId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementoFrontEnd_PaginaId",
                table: "ElementoFrontEnd",
                column: "PaginaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagens_Paginas_PaginaId",
                table: "Imagens",
                column: "PaginaId",
                principalTable: "Paginas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagens_Paginas_PaginaId",
                table: "Imagens");

            migrationBuilder.DropTable(
                name: "BackupPagina");

            migrationBuilder.DropTable(
                name: "ElementoFrontEnd");

            migrationBuilder.DropIndex(
                name: "IX_Imagens_PaginaId",
                table: "Imagens");

            migrationBuilder.DropColumn(
                name: "PaginaId",
                table: "Imagens");

            migrationBuilder.AddColumn<Guid>(
                name: "CssId",
                table: "Paginas",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HistoricoPaginaId",
                table: "Paginas",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ImagensId",
                table: "Paginas",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Javascript",
                table: "Paginas",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HistoricoPorPagina",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdPagina = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoPorPagina", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CSS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    CaminhoArquivoCss = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HistoricoCssFileId = table.Column<Guid>(type: "char(36)", nullable: true),
                    IdPagina = table.Column<Guid>(type: "char(36)", nullable: false),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Workflow = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CSS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CSS_HistoricoPorPagina_HistoricoCssFileId",
                        column: x => x.HistoricoCssFileId,
                        principalTable: "HistoricoPorPagina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paginas_CssId",
                table: "Paginas",
                column: "CssId");

            migrationBuilder.CreateIndex(
                name: "IX_Paginas_HistoricoPaginaId",
                table: "Paginas",
                column: "HistoricoPaginaId");

            migrationBuilder.CreateIndex(
                name: "IX_Paginas_ImagensId",
                table: "Paginas",
                column: "ImagensId");

            migrationBuilder.CreateIndex(
                name: "IX_CSS_HistoricoCssFileId",
                table: "CSS",
                column: "HistoricoCssFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paginas_CSS_CssId",
                table: "Paginas",
                column: "CssId",
                principalTable: "CSS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Paginas_HistoricoPorPagina_HistoricoPaginaId",
                table: "Paginas",
                column: "HistoricoPaginaId",
                principalTable: "HistoricoPorPagina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Paginas_Imagens_ImagensId",
                table: "Paginas",
                column: "ImagensId",
                principalTable: "Imagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
