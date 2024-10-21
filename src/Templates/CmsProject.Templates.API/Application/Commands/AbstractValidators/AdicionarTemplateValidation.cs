using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.API.Application.Commands.AbstractValidators
{
    public class AdicionarTemplateValidation : AbstractValidator<AdicionarTemplateCommand>
    {

        public AdicionarTemplateValidation()
        {
            RuleFor(c => c.Id)
               .NotEqual(Guid.Empty)
               .NotNull()
               .NotEmpty()
               .WithMessage("Id do template inválido");

            RuleFor(c => c.Nome)
               .NotNull()
               .NotEmpty()
               .WithMessage("Nome do template necessário");


            RuleFor(c => c.Status)
               .NotNull()
               .NotEmpty()
               .WithMessage("Status do template necessário");

        }
    }
}
