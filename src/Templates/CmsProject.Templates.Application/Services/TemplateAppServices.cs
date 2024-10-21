using AutoMapper;
using CmsProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CmsProject.Templates.Infrastructure.Repository;
using CmsProject.Core.Communication.GenericsCommunication;
using CmsProject.Core.Communication.Mediator;
using CmsProject.Templates.Application.ViewModels;
using CmsProject.Core.Repositories;
using CmsProject.Templates.Infrastructure;
using CmsProject.Core.DomainObjects;
using Microsoft.EntityFrameworkCore;

namespace CmsProject.Templates.Application.Services
{
    public class TemplateAppServices<T> : ITemplateAppServices where T : Entity
    {
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();
        private IMapper _mapper;
        private DbContext _context = null;
        TemplateRepository<T> _repository = null;

        public TemplateAppServices(IMapper mapper, DbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public void AdicionarPagina(PaginaViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void AdicionarTemplate(TemplatesViewModel viewModel)
        {
            _repository = new TemplateRepository<T>((TemplateContext)_context);
            var entity = _mapper.Map<T>(viewModel);

            _repository.Adicionar(entity);
        }

        public void AtualizarTemplate(TemplatesViewModel viewModel)
        {
            _repository = new TemplateRepository<T>((TemplateContext)_context);

            var updateEntity = _repository.ObterPorId(viewModel.Id);
            if (updateEntity != null)
            {
                var entity = _mapper.Map<T>(viewModel);
                _repository.Atualizar(entity);
            }
        }

    }
}
