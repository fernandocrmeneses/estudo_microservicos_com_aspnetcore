using System;
using System.Threading.Tasks;
using CmsProject.Core.Extensions;
using CmsProject.Catalogo.Api.Application.DTO;
using CmsProject.Catalogo.Api.Application.Commands;
using CmsProject.Core.Communication.Mediator;
using CmsProject.WebApi.Core.Usuario;
using CmsProject.Catalogo.Api.Application.Queries;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CmsProject.Catalogo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoController : MainController
    {
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IAspNetUser _usuario;
        private readonly ICatalogoQueries _catalogoQuerie;

        public CatalogoController(IMediatorHandler mediator, IAspNetUser user, ICatalogoQueries catalogoQueries)
        {
            _mediatorHandler = mediator;
            _usuario = user;
            _catalogoQuerie = catalogoQueries;
        }

        [HttpPost("adicionarproduto")]
        public async Task<IActionResult> AdicionarProdutoNoCatalogo(ProdutoDTO produto)
        {
            var comandoAdicionaProduto = new AdicionarProdutoCommando(_usuario.ObterUserId(), produto.IdProduto, produto.Nome, produto.QuantidadeEstoque, produto.Valor);
            return CustomResponse(await _mediatorHandler.EnviarComando(comandoAdicionaProduto));
        }

        [HttpGet("produtos")]
        public async Task<IActionResult> ObtemTodosProdutosDoCatalogo()
        {
            var catalogos = _catalogoQuerie.ObtemTodosProdutos();
            return await Task.FromResult(CustomResponse(catalogos));
        }

        [HttpPut("atualizarproduto")]
        public async Task<IActionResult> AtualizarProdutoNoCatalogo(ProdutoDTO produto)
        {
            var comandoAtualizaProduto = new AtualizarProdutoCommando(_usuario.ObterUserId(), produto.IdProduto, produto.Nome, produto.QuantidadeEstoque, produto.Valor);
            return CustomResponse(await _mediatorHandler.EnviarComando(comandoAtualizaProduto));
        }

        [HttpDelete("removerproduto/{id}")]
        public async Task<IActionResult> InativarProdutoDoCatalogo(Guid id)
        {
            var comandoRemoveProduto = new InativarProdutoCommando(_usuario.ObterUserId(), id);
            return CustomResponse(await _mediatorHandler.EnviarComando(comandoRemoveProduto));
        }
    }
}
