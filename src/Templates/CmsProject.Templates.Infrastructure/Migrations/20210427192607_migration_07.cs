using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CmsProject.Templates.Infrastructure.Migrations
{
    public partial class migration_07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BackupElementoFrontEnd",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    ElementoFrontEndId = table.Column<Guid>(nullable: true),
                    IdElementoFrontEnd = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackupElementoFrontEnd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BackupElementoFrontEnd_ElementoFrontEnd_ElementoFrontEndId",
                        column: x => x.ElementoFrontEndId,
                        principalTable: "ElementoFrontEnd",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BackupElementoFrontEnd_ElementoFrontEndId",
                table: "BackupElementoFrontEnd",
                column: "ElementoFrontEndId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackupElementoFrontEnd");
        }
    }
}
