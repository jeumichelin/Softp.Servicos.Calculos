using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Softp.Servicos.Calculos.Infra.CrossCutting.Ioc
{
public static class SwaggerInjection
    {

        public static void AddSwagger(this IServiceCollection services, Assembly apiAssembly)
        {
            services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new OpenApiInfo
                    {
                        Version = "v1",
                        Title = "Api de Cálculos",
                        Description = "Api de Cálculos",
                        TermsOfService = new Uri("https://example.com/terms"),
                        Contact = new OpenApiContact
                        {
                            Name = "Jeferson Michelin",
                            Email = string.Empty,
                            Url = new Uri("https://example.com/license")
                        },
                        License = new OpenApiLicense
                        {
                            Name = "Use under LICX",
                            Url = new Uri("https://example.com/license")
                        }
                    });

                    // Set the comments path for the Swagger JSON and UI.
                    var xmlFile = $"{apiAssembly.GetName().Name}.xml";
                    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                    options.IncludeXmlComments(xmlPath);
                }
            );
        }

        public static void UseSwaggerConfiguration(this IApplicationBuilder app, IConfiguration configuration)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(configuration["SwaggerEndpoint"], "API");
                c.RoutePrefix = string.Empty;
            });
        }
    }

}
