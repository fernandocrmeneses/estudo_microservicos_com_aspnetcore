using AutoMapper;
using CmsProject.Usuarios.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Usuarios.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Domain.Usuarios, UsuariosViewModel>();

            CreateMap<Domain.Sistemas, SistemasViewModel>();
        }
    }
}
