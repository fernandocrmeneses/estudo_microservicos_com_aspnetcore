using AutoMapper;
using CmsProject.Catalogo.Api.Application.Events;
using CmsProject.Catalogo.Domain;
using CmsProject.Catalogo.Domain.Interfaces;
using CmsProject.Core.Communication.Mediator;
using CmsProject.Core.Messages;
using CmsProject.Core.Messages.CommonMessages.Notifications;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CmsProject.Catalogo.Api.Application.Commands
{
    public class CatalogoCommandHandler :
        IRequestHandler<AdicionarProdutoCommando, bool>,
        IRequestHandler<AtualizarProdutoCommando, bool>,
        IRequestHandler<InativarProdutoCommando, bool>
    {
        private readonly IProdutoRepository _produtoRepositorio;
        private readonly IMediatorHandler _mediator;
        private readonly IMapper _mapper;

        public CatalogoCommandHandler(IProdutoRepository produtoRepositorio, IMediatorHandler mediator, IMapper mapper)
        {
            _produtoRepositorio = produtoRepositorio;
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Comando para adicionar o produto na base de dados, e também dispara o evento CatalogoProdutoAdicionadoEvent, para salvar na eventstore.
        /// </summary>
        /// <param name="request">Objeto do request com os dados a serem salvos na base de dados.</param>
        /// <param name="cancellationToken">Token de cancelamento.</param>
        /// <returns>Retorno boleano assincrono, ao adicionar o produto.</returns>
        public async Task<bool> Handle(AdicionarProdutoCommando request, CancellationToken cancellationToken)
        {
            if (!ValidarComando(request))
                return false;

            var produto = _mapper.Map<Produtos>(request);
            produto.AdicionarEvento(
                new CatalogoProdutoAdicionadoEvent(
                request.ClienteId,
                request.ProdutoId,
                request.Nome,
                request.Quantidade));

            _produtoRepositorio.Adicionar(produto);

            return await _produtoRepositorio.UnitOfWork.Commit();
        }

        /// <summary>
        /// Comando para atualizar o produto na base de dados, e também dispara o evento CatalogoProdutoAtualizadoEvent, para salvar na eventstore.
        /// </summary>
        /// <param name="request">Objeto do request com os dados a serem atualizados na base de dados.</param>
        /// <param name="cancellationToken">Token de cancelamento.</param>
        /// <returns>Retorno boleano sincrono, ao atualizar o produto.</returns>
        public async Task<bool> Handle(AtualizarProdutoCommando request, CancellationToken cancellationToken)
        {
            if (!ValidarComando(request))
                return false;

            var produto = await _produtoRepositorio.ObterPorId(request.ProdutoId);
            var evento = new CatalogoProdutoAtualizadoEvent(request.ClienteId, request.ProdutoId, request.Nome, request.Quantidade);
            produto?.AdicionarEvento(evento);

            if (produto == null)
            {
                await _mediator.PublicarNotificacao(new DomainNotification("Produto", "produto não cadastrado"));
                return false;
            }
            
            _ = _mediator.PublicarEvento(evento);

            _produtoRepositorio.Atualizar(_mapper.Map<Produtos>(request));
            return await _produtoRepositorio.UnitOfWork.Commit();
        }

        /// <summary>
        /// Comando para remover o produto na base de dados, e também dispara o evento CatalogoProdutoRemovidoEvent, para salvar na eventstore.
        /// </summary>
        /// <param name="request">Objeto do request com os dados a serem atualizados na base de dados.</param>
        /// <param name="cancellationToken">Token de cancelamento.</param>
        /// <returns>Retorno boleano sincrono, ao atualizar o produto.</returns>
        public async Task<bool> Handle(InativarProdutoCommando request, CancellationToken cancellationToken)
        {
            if (!ValidarComando(request))
                return false;

            _produtoRepositorio.Desativar(_mapper.Map<Produtos>(request).Id);
            return await _produtoRepositorio.UnitOfWork.Commit();
        }

        private bool ValidarComando(Command message)
        {
            if (message.EhValido()) return true;

            foreach (var error in message.ValidationResult.Errors)
            {
                _mediator.PublicarNotificacao(new DomainNotification(message.MessageType, error.ErrorMessage));
            }

            return false;
        }
    }
}
