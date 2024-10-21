using CmsProject.Catalogo.Api.Application.Commands;
using FluentValidation;
using System;

namespace CmsProject.Catalogo.Api.Application.Validations
{
    public class AdicionarProdutoValidacao : AbstractValidator<AdicionarProdutoCommando>
    {
        public AdicionarProdutoValidacao()
        {
            RuleFor(c=>c.ProdutoId)
                .NotEmpty()
                .NotEqual(Guid.Empty)
                .WithMessage("Id do produto invalido!");
        }
    }
}
