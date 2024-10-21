using CmsProject.Templates.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using CmsProject.Templates.Application.AutoMapper;
using AutoMapper;

namespace CmsProject.Templates.API.Application.AutoMapper
{
    public class ViewModelDomainTemplate : Profile
    {
        public ViewModelDomainTemplate()
        {
            CreateMap<PaginaViewModel, Domain.Pagina>();
            CreateMap<TemplatesViewModel, Domain.Templates>();

            CreateMap<TemplatesViewModel, Domain.Templates>()
                .ConstructUsing(c => new Domain.Templates(c.Nome, c.Status));
        }

        //public void Configure()
        //{
        //    CreateMap<PaginaViewModel, Domain.Pagina>();
        //    CreateMap<TemplatesViewModel, Domain.Templates>();
        //}
    }
}
