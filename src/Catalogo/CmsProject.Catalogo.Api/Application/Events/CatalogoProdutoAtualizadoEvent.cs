using CmsProject.Core.Messages;
using System;

namespace CmsProject.Catalogo.Api.Application.Events
{
    public class CatalogoProdutoAtualizadoEvent : Event
    {
        public Guid ClienteId { get; private set; }
        public Guid ProdutoId { get; private set; }
        public string Nome { get; private set; }
        public int Quantidade { get; private set; }

        public CatalogoProdutoAtualizadoEvent(Guid clienteId, Guid produtoId, string nome, int quantidade)
        {
            ClienteId = clienteId;
            ProdutoId = produtoId;
            Nome = nome;
            Quantidade = quantidade;
        }
    }
}
