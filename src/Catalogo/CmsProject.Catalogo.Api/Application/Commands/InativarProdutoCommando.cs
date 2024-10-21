using CmsProject.Core.Messages;
using System;

namespace CmsProject.Catalogo.Api.Application.Commands
{
    public class InativarProdutoCommando : Command
    {
        public Guid ClienteId { get; private set; }
        public Guid ProdutoId { get; private set; }
        public string Nome { get; private set; }
        public int Quantidade { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public InativarProdutoCommando(Guid clienteId, Guid produtoId)
        {
            ClienteId = clienteId;
            ProdutoId = produtoId;
        }
    }
}
