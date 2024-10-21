using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using CmsProject.Templates.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using CmsProject.Core.Communication.Mediator;
using CmsProject.Templates.Application.ViewModels;
using CmsProject.Templates.Application.Commands;
using FluentValidation.Results;
using CmsProject.Templates.API.Application.DTO;

namespace CmsProject.Templates.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            #region configuration commandHandlers
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IRequestHandler<AdicionarTemplateCommand, bool>, TemplatesCommandHandler>();
            #endregion configuration commandHandlers

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            services.AddScoped<TemplateContext>();
            services.AddAutoMapper(typeof(Domain.Templates), typeof(TemplatesDTO));
            services.AddAutoMapper(typeof(TemplatesDTO), typeof(Domain.Templates));
            services.AddAutoMapper(typeof(Domain.Pagina), typeof(PaginaDTO));

            ////Templates
            services.AddDbContext<TemplateContext>(options =>
               options.UseMySql(Configuration.GetConnectionString("Country32_Templates_system")));

            services.AddMediatR(typeof(TemplatesCommandHandler).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(Startup));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
