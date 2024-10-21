using CmsProject.Core.DomainObjects;
using CmsProject.Core.Messages;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CmsProject.Core.Communication.GenericsCommunication
{
    public class AddCommand<TEntity> : Command where TEntity : Entity
    {
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public Guid Id { get; set; }

        public AddCommand(DateTime dataCriacao, Guid Id)
        {
            DataCriacao = dataCriacao;
            DataAtualizacao = dataCriacao;
            Id = Id;
        }

        //public override bool EhValido()
        //{
        //    ValidationResult = new AddCommandValidation<TEntity>().Validate(this);
        //    return ValidationResult.IsValid;
        //}
    }


    public class AddCommandValidation<T> : AbstractValidator<T> where T : Entity
    {
        public AddCommandValidation()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty)
                .WithMessage("Id do cliente inválido");
        }
    }
}
