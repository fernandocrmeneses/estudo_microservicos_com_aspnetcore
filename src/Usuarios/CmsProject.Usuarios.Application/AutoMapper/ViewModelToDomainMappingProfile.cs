using AutoMapper;
using CmsProject.Usuarios.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Usuarios.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UsuariosViewModel, Domain.Usuarios>();

            CreateMap<SistemasViewModel, Domain.Sistemas>();
        }
    }
}
