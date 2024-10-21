using AutoMapper.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace CmsProject.Catalogo.Api.Configuration
{
    public static class ApiSwaggerConfig
    {
        public static void AddSwaggerConfiguracao(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "CMS Project - Serviços Prestados API",
                    Description = "[ServicosPrestados] - API relacionada ao Servicos Prestados pelos os usuarios.",
                    Contact = new OpenApiContact() { Name = "Fernando Meneses", Email = "contatoDev@gmail.com" },
                    License = new OpenApiLicense() { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }
                });
                c.AddSecurityDefinition(name: "Bearer", new OpenApiSecurityScheme
                {
                    Description = "Insira o token dessa maneira: Bearer {seuToken}",
                    Name = "Authorization",
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey

                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[]{ }
                }
            });
            });
        }
    }
}
