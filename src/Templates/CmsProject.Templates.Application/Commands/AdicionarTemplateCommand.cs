using CmsProject.Core.Messages;
using CmsProject.Templates.Application.Commands.AbstractValidators;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Application.Commands
{
    public class AdicionarTemplateCommand : Command
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public int Status { get; private set; }

        public AdicionarTemplateCommand(Guid id, string nome, int status)
        {
            AggregateId = id;
            Id = id;
            Nome = nome;
            Status = status;
        }

        public override bool EhValido()
        {
            ValidationResult = new AdicionarTemplateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
