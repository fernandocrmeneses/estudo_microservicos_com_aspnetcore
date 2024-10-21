using CmsProject.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Catalogo.Domain
{
    public class Catalogo : Entity, IAggregateRoot
    {

        public string Nome { get; set; }
        public int CodigoCatalogo { get; set; }
        public Catalogo() { }
        public ICollection<Categoria> Categorias { get; set; }
    }
}
