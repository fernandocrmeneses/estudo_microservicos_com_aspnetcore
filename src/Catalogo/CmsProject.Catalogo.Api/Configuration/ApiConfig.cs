using CmsProject.Catalogo.Api.Application.AutoMapper;
using CmsProject.Catalogo.Api.Application.Queries;
using CmsProject.Catalogo.Domain.Interfaces;
using CmsProject.Catalogo.Infrastructure;
using CmsProject.Catalogo.Infrastructure.Repository;
using CmsProject.Core.Communication.Mediator;
using CmsProject.Core.Data.EventSourcing;
using CmsProject.Core.Messages.CommonMessages.Notifications;
using EventSourcing;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using CmsProject.WebApi.Core.Usuario;

namespace CmsProject.Catalogo.Api.Configuration
{
    public static class ApiConfig
    {
        public static void AddApiConfiguracao(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CatalogoContext>(options =>
                options.UseMySql(configuration.GetConnectionString("Country32_Catalogo")));

            //Contextos
            services.AddScoped<ICatalogoQueries, CatalogoQueries>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

            // Mediator
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            // Notifications
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

            // AspNet User
            //services.AddScoped<IAspNetUser, AspNetUserImplementation>();

            // Event Sourcing
            services.AddSingleton<IEventStoreService, EventStoreService>();
            services.AddSingleton<IEventSourcingRepository, EventSourcingRepository>();

            //AutoMapper
            services.AddAutoMapper(typeof(DominioParaDTO), typeof(DTOParaDominio));
        }
    }
}
