using CmsProject.Catalogo.Domain;
using System;

namespace CmsProject.Catalogo.Api.Application.DTO
{
    public class ProdutoDTO
    {
        public Guid IdProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get;  set; }
        public decimal Valor { get;  set; }
        public DateTime DataCadastro { get;  set; }
        public string Imagem { get;  set; }
        public int QuantidadeEstoque { get;  set; }
        public Categoria Categoria { get;  set; }
        public Guid IdCategoria { get;  set; }
        public decimal Altura { get;  set; }
        public decimal Largura { get;  set; }
        public decimal Profundidade { get;  set; }
    }
}
