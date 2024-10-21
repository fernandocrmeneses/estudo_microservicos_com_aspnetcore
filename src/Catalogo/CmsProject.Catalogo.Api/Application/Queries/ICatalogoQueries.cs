using CmsProject.Catalogo.Api.Application.DTO;
using System.Collections.Generic;

namespace CmsProject.Catalogo.Api.Application.Queries
{
    public interface ICatalogoQueries
    {
        List<CatalagoDTO> ObtemCatalago();
        List<ProdutoDTO> ObtemTodosProdutos();
    }
}
