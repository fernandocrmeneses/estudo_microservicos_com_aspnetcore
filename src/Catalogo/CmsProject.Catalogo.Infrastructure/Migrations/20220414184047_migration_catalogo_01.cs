using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CmsProject.Catalogo.Infrastructure.Migrations
{
    public partial class migration_catalogo_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Codigo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Imagem = table.Column<string>(nullable: true),
                    QuantidadeEstoque = table.Column<int>(nullable: false),
                    CategoriaId = table.Column<Guid>(nullable: true),
                    IdCategoria = table.Column<Guid>(nullable: false),
                    Altura = table.Column<decimal>(nullable: false),
                    Largura = table.Column<decimal>(nullable: false),
                    Profundidade = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    QuantidadeSemanais = table.Column<int>(nullable: false),
                    ServicoDataHoraInicio = table.Column<DateTime>(nullable: false),
                    ServicoDataHoraFim = table.Column<DateTime>(nullable: false),
                    ServicoDisponivel = table.Column<bool>(nullable: false),
                    RaioServicoPrestado = table.Column<long>(nullable: false),
                    IdUser = table.Column<Guid>(nullable: false),
                    IdProduto = table.Column<Guid>(nullable: false),
                    ValorServico = table.Column<decimal>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    IdCategoria = table.Column<Guid>(nullable: false),
                    CategoriaId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicos_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_CategoriaId",
                table: "Servicos",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
