using AutoMapper;
using CmsProject.Sistemas.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsProject.Sistemas.API.AutoMapper
{
    public class SistemasViewModelToDomainMappingProfile : Profile
    {
        public SistemasViewModelToDomainMappingProfile()
        {
            CreateMap<SistemasViewModel, SistemasDomainToViewModelMappingProfile>();

            CreateMap<SistemasViewModel, Domain.Sistemas>();
        }
    }
}
