using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CmsProject.Core.Messages;
using MediatR;
using FluentValidation.Results;
using CmsProject.Templates.Application.Services;
using CmsProject.Core.Data;
using AutoMapper;
using CmsProject.Templates.Infrastructure.Repository;
using CmsProject.Templates.Infrastructure;
using CmsProject.Templates.Application.ViewModels;

namespace CmsProject.Templates.API.Application.Commands
{
    public class TemplatesCommandHandler : CommandHandler,
        IRequestHandler<AdicionarTemplateCommand, bool>
    {
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();
        private IMapper _mapper;
        private TemplateContext _context = null;
        public TemplatesCommandHandler(IMapper mapper, TemplateContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<bool> Handle(AdicionarTemplateCommand message, CancellationToken cancellationToken)
        {
            try
            {
                if (!message.EhValido()) return false;

                var service = new TemplateAppServices<Domain.Templates>(mapper: _mapper, context: _context);
                TemplatesViewModel template = new TemplatesViewModel()
                {
                    Nome = message.Nome,
                    Status = message.Status,
                    Id = message.Id

                };
                service.AdicionarTemplate(template);

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
