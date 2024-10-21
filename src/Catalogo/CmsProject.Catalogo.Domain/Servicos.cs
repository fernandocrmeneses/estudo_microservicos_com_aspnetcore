using CmsProject.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Catalogo.Domain
{
    public class Servicos : Entity, IAggregateRoot
    {
        protected Servicos() { }
        public string Nome { get; private set; }
        public int QuantidadeSemanais { get; private set; }

        public DateTime ServicoDataHoraInicio { get; private set; }

        public DateTime ServicoDataHoraFim { get; private set; }

        public bool ServicoDisponivel { get; private set; }

        public long RaioServicoPrestado { get; private set; }

        public Guid IdUser { get; private set; }

        public Guid IdProduto { get; private set; }

        public decimal ValorServico { get; private set; }

        public bool Ativo { get; private set; }

        public Guid IdCategoria { get; private set; }
        public Categoria Categoria { get; private set; }


    }
}
