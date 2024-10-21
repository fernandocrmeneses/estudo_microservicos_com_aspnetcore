using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CmsProject.Templates.Infrastructure.Migrations
{
    public partial class migration_08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TemplatesId",
                table: "Paginas",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paginas_TemplatesId",
                table: "Paginas",
                column: "TemplatesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paginas_Templates_TemplatesId",
                table: "Paginas",
                column: "TemplatesId",
                principalTable: "Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paginas_Templates_TemplatesId",
                table: "Paginas");

            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropIndex(
                name: "IX_Paginas_TemplatesId",
                table: "Paginas");

            migrationBuilder.DropColumn(
                name: "TemplatesId",
                table: "Paginas");
        }
    }
}
