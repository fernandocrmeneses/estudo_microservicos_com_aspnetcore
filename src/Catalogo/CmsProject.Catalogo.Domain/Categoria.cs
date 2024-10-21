using CmsProject.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }
        public int Codigo { get; private set; }

        // EF Relation
        public ICollection<Produtos> Produtos { get; set; }
        public ICollection<Servicos> Servicos { get; set; }

        public Guid IdCatalogo { get; set; }

        protected Categoria() { }
    }
}
