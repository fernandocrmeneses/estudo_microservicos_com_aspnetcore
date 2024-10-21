using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CmsProject.Auth.Api.ViewModels;

namespace CmsProject.Auth.Api.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UsuariosViewModel, Usuarios.Domain.Usuarios>();
        }
    }
}
