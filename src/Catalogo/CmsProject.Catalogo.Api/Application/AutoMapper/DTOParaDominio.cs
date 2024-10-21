using AutoMapper;
using CmsProject.Catalogo.Api.Application.DTO;

namespace CmsProject.Catalogo.Api.Application.AutoMapper
{
    public class DTOParaDominio : Profile
    {
        public DTOParaDominio()
        {
            CreateMap<ProdutoDTO, Domain.Produtos>();
            CreateMap<CategoriaDTO, Domain.Categoria>();
            CreateMap<CatalagoDTO, Domain.Catalogo>();
        }
    }
}
