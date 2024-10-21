using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CmsProject.Templates.Infrastructure.Migrations
{
    public partial class migration_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "HistoricoPaginaId",
                table: "Paginas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paginas_HistoricoPaginaId",
                table: "Paginas",
                column: "HistoricoPaginaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paginas_Historico_HistoricoPaginaId",
                table: "Paginas",
                column: "HistoricoPaginaId",
                principalTable: "Historico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paginas_Historico_HistoricoPaginaId",
                table: "Paginas");

            migrationBuilder.DropIndex(
                name: "IX_Paginas_HistoricoPaginaId",
                table: "Paginas");

            migrationBuilder.DropColumn(
                name: "HistoricoPaginaId",
                table: "Paginas");
        }
    }
}
