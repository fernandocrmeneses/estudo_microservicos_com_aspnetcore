using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.API.Application.Commands.AbstractValidators
{
    public class AdicionarPaginaValidation : AbstractValidator<AdicionarPaginaCommand>
    {
        public AdicionarPaginaValidation()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty)
                .WithMessage("Id da pagina inválido");


            RuleFor(c => c.IdUsuario)
               .NotEqual(Guid.Empty)
               .WithMessage("IdUsuario da pagina inválido");

            RuleFor(c => c.TemplatesId)
                .NotEmpty()
                .NotEqual(Guid.Empty)
                .NotNull()
               .WithMessage("Template da pagina inválido, o Template deve ser criado");


            RuleFor(c => c.Nome)
                .NotEmpty()
                .WithMessage("O nome da pagina não foi informado");

            RuleFor(c => c.Header)
                .NotEmpty()
                .WithMessage("O Header da pagina não foi informado");

            RuleFor(c => c.Body)
               .NotEmpty()
               .WithMessage("O Body da pagina não foi informado");

            RuleFor(c => c.Categoria)
               .NotEmpty()
               .WithMessage("O Categoria da pagina não foi informado");

            RuleFor(c => c.DataAtualizacao)
               .NotEmpty()
               .WithMessage("A Data de atualizacao da pagina não foi informado");

            RuleFor(c => c.DataCriacao)
               .NotEmpty()
               .WithMessage("A Data de criação da pagina não foi informado");

            RuleFor(c => c.Footer)
              .NotEmpty()
              .WithMessage("O Footer de criação da pagina não foi informado");

            RuleFor(c => c.Menu)
              .NotEmpty()
              .WithMessage("O Menu de criação da pagina não foi informado");

            RuleFor(c => c.Status)
              .NotEmpty()
              .WithMessage("O Status de criação da pagina não foi informado");

            RuleFor(c => c.WorkFlow)
              .NotEmpty()
              .WithMessage("O Workflow de criação da pagina não foi informado");

            RuleFor(c => c.ElementoFrontEnd)
              .NotEmpty()
              .WithMessage("Necessário o CSS ou Javascript na pagina");

        }
    }
}
