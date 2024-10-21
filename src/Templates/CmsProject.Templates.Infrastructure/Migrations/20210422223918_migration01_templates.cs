using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CmsProject.Templates.Infrastructure.Migrations
{
    public partial class migration01_templates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Historico",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    IdBackup = table.Column<Guid>(nullable: false),
                    DataHistorico = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Imagens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    CaminhoImagem = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    IdPagina = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CSS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    IdPagina = table.Column<Guid>(nullable: false),
                    CaminhoArquivoCss = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Workflow = table.Column<int>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    HistoricoCssFileId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CSS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CSS_Historico_HistoricoCssFileId",
                        column: x => x.HistoricoCssFileId,
                        principalTable: "Historico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Paginas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    Header = table.Column<string>(nullable: true),
                    Menu = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Footer = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Categoria = table.Column<string>(nullable: true),
                    CssId = table.Column<Guid>(nullable: true),
                    Javascript = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    WorkFlow = table.Column<int>(nullable: false),
                    ImagensId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paginas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paginas_CSS_CssId",
                        column: x => x.CssId,
                        principalTable: "CSS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Paginas_Imagens_ImagensId",
                        column: x => x.ImagensId,
                        principalTable: "Imagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CSS_HistoricoCssFileId",
                table: "CSS",
                column: "HistoricoCssFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Paginas_CssId",
                table: "Paginas",
                column: "CssId");

            migrationBuilder.CreateIndex(
                name: "IX_Paginas_ImagensId",
                table: "Paginas",
                column: "ImagensId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paginas");

            migrationBuilder.DropTable(
                name: "CSS");

            migrationBuilder.DropTable(
                name: "Imagens");

            migrationBuilder.DropTable(
                name: "Historico");
        }
    }
}
