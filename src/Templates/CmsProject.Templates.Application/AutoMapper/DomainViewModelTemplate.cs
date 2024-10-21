using AutoMapper;
using CmsProject.Templates.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Application.AutoMapper
{
    public class DomainViewModelTemplate:Profile
    {
        public DomainViewModelTemplate()
        {
            CreateMap<Domain.Pagina, PaginaViewModel>();
            CreateMap<Domain.Templates, TemplatesViewModel>();
        }

        public void Configure()
        {
            CreateMap<Domain.Pagina, PaginaViewModel>();
            CreateMap<Domain.Templates, TemplatesViewModel>();
        }
    }
}
