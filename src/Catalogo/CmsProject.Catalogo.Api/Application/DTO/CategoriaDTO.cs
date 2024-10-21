using CmsProject.Catalogo.Domain;
using System;
using System.Collections.Generic;

namespace CmsProject.Catalogo.Api.Application.DTO
{
    public class CategoriaDTO
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }

        public List<ProdutoDTO> Produtos { get; set; }
        public List<Servicos> Servicos { get; set; }

        public Guid IdCatalogo { get; set; }
    }
}
