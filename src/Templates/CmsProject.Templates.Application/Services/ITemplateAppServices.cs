using CmsProject.Core.Data;
using CmsProject.Core.Repositories;
using CmsProject.Templates.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Application.Services
{
    public interface ITemplateAppServices
    {
        void AdicionarPagina(PaginaViewModel viewModel);
        void AdicionarTemplate(TemplatesViewModel viewModel);
    }
}
