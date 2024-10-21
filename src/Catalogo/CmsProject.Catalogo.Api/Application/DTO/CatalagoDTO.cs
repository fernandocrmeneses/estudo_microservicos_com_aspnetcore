using System.Collections.Generic;

namespace CmsProject.Catalogo.Api.Application.DTO
{
    public class CatalagoDTO
    {
        public string Nome { get; set; }
        public int CodigoCatalogo { get; set; }

        public List<CategoriaDTO> Categorias { get; set; }
    }
}
