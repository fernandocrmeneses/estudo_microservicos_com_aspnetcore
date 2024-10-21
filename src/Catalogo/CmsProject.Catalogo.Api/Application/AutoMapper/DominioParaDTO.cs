using AutoMapper;
using CmsProject.Catalogo.Api.Application.DTO;

namespace CmsProject.Catalogo.Api.Application.AutoMapper
{
    public class DominioParaDTO : Profile
    {
        public DominioParaDTO()
        {
            CreateMap<Domain.Produtos, ProdutoDTO>();
            CreateMap<Domain.Catalogo, CatalagoDTO>();
            CreateMap<Domain.Categoria, CategoriaDTO>();
        }
    }
}
