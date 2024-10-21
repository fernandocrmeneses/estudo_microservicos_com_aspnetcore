using CmsProject.Catalogo.Api.Application.Commands;
using FluentValidation;
using System;

namespace CmsProject.Catalogo.Api.Application.Validations
{
    public class AtualizarProdutoValidacao : AbstractValidator<AtualizarProdutoCommando>
    {
        public AtualizarProdutoValidacao()
        {
            RuleFor(c => c.ProdutoId)
                .NotEqual(Guid.Empty)
                .NotEmpty()
                .WithMessage("Id do produto invalido para atualizãção!");
        }
    }
}
