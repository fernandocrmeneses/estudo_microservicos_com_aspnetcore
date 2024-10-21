using CmsProject.Core.Communication.Mediator;
using CmsProject.Core.Data.EventSourcing;
using CmsProject.Core.Messages.CommonMessages.Notifications;
using EventSourcing;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace CmsProject.Presentation.Web.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Mediator
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            // Notifications
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

            // Event Sourcing
            services.AddSingleton<IEventStoreService, EventStoreService>();
            services.AddSingleton<IEventSourcingRepository, EventSourcingRepository>();

            // Catalogo
            //services.AddScoped<IProdutoRepository, ProdutoRepository>();
            
            //services.AddScoped<IProdutoAppService, ProdutoAppService>();
            //services.AddScoped<IEstoqueService, EstoqueService>();
           // services.AddScoped<CatalogoContext>();

            //services.AddDbContext<UsuariosContexts>();
            //services.AddIdentity<IdentityUser, IdentityRole>()
            //                .AddEntityFrameworkStores<UsuariosContexts>()
            //                .AddDefaultTokenProviders();

            //services.AddScoped<INotificationHandler<ProdutoAbaixoEstoqueEvent>, ProdutoEventHandler>();
            //services.AddScoped<INotificationHandler<PedidoIniciadoEvent>, ProdutoEventHandler>();
            //services.AddScoped<INotificationHandler<PedidoProcessamentoCanceladoEvent>, ProdutoEventHandler>();

            // Vendas
            //services.AddScoped<IPedidoRepository, PedidoRepository>();
            //services.AddScoped<IPedidoQueries, PedidoQueries>();
            //services.AddScoped<VendasContext>();

            //services.AddScoped<IRequestHandler<AdicionarItemPedidoCommand, bool>, PedidoCommandHandler>();
            //services.AddScoped<IRequestHandler<AtualizarItemPedidoCommand, bool>, PedidoCommandHandler>();
            //services.AddScoped<IRequestHandler<RemoverItemPedidoCommand, bool>, PedidoCommandHandler>();
            //services.AddScoped<IRequestHandler<AplicarVoucherPedidoCommand, bool>, PedidoCommandHandler>();
            //services.AddScoped<IRequestHandler<IniciarPedidoCommand, bool>, PedidoCommandHandler>();
            //services.AddScoped<IRequestHandler<FinalizarPedidoCommand, bool>, PedidoCommandHandler>();
            //services.AddScoped<IRequestHandler<CancelarProcessamentoPedidoCommand, bool>, PedidoCommandHandler>();
            //services.AddScoped<IRequestHandler<CancelarProcessamentoPedidoEstornarEstoqueCommand, bool>, PedidoCommandHandler>();

            //services.AddScoped<INotificationHandler<PedidoRascunhoIniciadoEvent>, PedidoEventHandler>();
            //services.AddScoped<INotificationHandler<PedidoEstoqueRejeitadoEvent>, PedidoEventHandler>();
            //services.AddScoped<INotificationHandler<PedidoPagamentoRealizadoEvent>, PedidoEventHandler>();
            //services.AddScoped<INotificationHandler<PedidoPagamentoRecusadoEvent>, PedidoEventHandler>();

            // Pagamento
            //services.AddScoped<IPagamentoRepository, PagamentoRepository>();
            //services.AddScoped<IPagamentoService, PagamentoService>();
            //services.AddScoped<IPagamentoCartaoCreditoFacade, PagamentoCartaoCreditoFacade>();
            //services.AddScoped<IPayPalGateway, PayPalGateway>();
            //services.AddScoped<IConfigurationManager, ConfigurationManager>();
            //services.AddScoped<PagamentoContext>();

            //services.AddScoped<INotificationHandler<PedidoEstoqueConfirmadoEvent>, PagamentoEventHandler>();
        }
    }
}
