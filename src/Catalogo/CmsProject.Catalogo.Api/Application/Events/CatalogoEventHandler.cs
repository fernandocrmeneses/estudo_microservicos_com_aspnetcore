using CmsProject.Core.Communication.Mediator;
using CmsProject.Core.Messages;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CmsProject.Catalogo.Api.Application.Events
{
    public class CatalogoEventHandler :
        INotificationHandler<CatalogoProdutoAdicionadoEvent>,
        INotificationHandler<CatalogoProdutoAtualizadoEvent>,
        INotificationHandler<CatalogoProdutoRemovidoEvent>
    {
        private readonly IMediatorHandler _mediatorHandler;

        public CatalogoEventHandler(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        /// <summary>
        /// Evento acionado ao incluir o produto na base de dados correspondente a esse contexto de Catalogo e a base no-sql.
        /// </summary>
        /// <param name="notification">Objeto notification.</param>
        /// <param name="cancellationToken">Token do cancelamento do evento.</param>
        /// <returns>Retonar uma tarefa completada. </returns>
        public Task Handle(CatalogoProdutoAdicionadoEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// Evento acionado ao atualizar o produto na base de dados correspondente a esse contexto de Catalogo e a base no-sql.
        /// </summary>
        /// <param name="notification">Objeto notification.</param>
        /// <param name="cancellationToken">Token do cancelamento do evento.</param>
        /// <returns>Retonar uma tarefa completada. </returns>
        public Task Handle(CatalogoProdutoAtualizadoEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// Evento acionado ao remover o produto na base de dados correspondente a esse contexto de Catalogo e a base no-sql, quando ocorrer a remoção do a notificação deve ser disparada.
        /// </summary>
        /// <param name="notification">Objeto de notificacao.</param>
        /// <param name="cancellationToken">Token de cancelamento do evento.</param>
        /// <returns>Retonar uma tarefa completada. </returns>
        public Task Handle(CatalogoProdutoRemovidoEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
