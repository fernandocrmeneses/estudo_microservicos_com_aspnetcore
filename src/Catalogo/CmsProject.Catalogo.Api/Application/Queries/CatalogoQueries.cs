using AutoMapper;
using CmsProject.Catalogo.Api.Application.DTO;
using CmsProject.Catalogo.Domain.Interfaces;
using System.Collections.Generic;

namespace CmsProject.Catalogo.Api.Application.Queries
{
    /// <summary>
    /// CatalogoQueries é uma classe apenas para consultas.
    /// </summary>
    public class CatalogoQueries : ICatalogoQueries
    {
        private readonly IProdutoRepository _repositorioProduto;
        private readonly IMapper _mapper;
        public CatalogoQueries(
            IProdutoRepository repositorioProduto,
            IMapper mapper)
        {
            _repositorioProduto = repositorioProduto;
            _mapper = mapper;
        }

        public List<CatalagoDTO> ObtemCatalago()
        {
            throw new System.NotImplementedException();
        }

        public List<ProdutoDTO> ObtemTodosProdutos()
        {
            return _mapper.Map<List<ProdutoDTO>>(_repositorioProduto.ObterTodos());
        }

        public CatalagoDTO ObtemCatalogoPorId(int id) {  throw new System.NotImplementedException(); }

    }
}
