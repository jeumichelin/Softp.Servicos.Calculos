using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Softp.Servicos.Calculos.Domain.interfaces;
using Softp.Servicos.Calculos.Infra.CrossCutting.ExternalServices.Services;


namespace Softp.Servicos.Calculos.Infra.CrossCutting.Ioc
{
    public static class ApiServiceInjection
    {
        public static void AddApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<ITaxasApiService, TaxasApiService>(client =>
            {
                client.BaseAddress = new Uri(configuration.GetValue<string>("ApiTaxas:Endpoint"));
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });
        }
    }
}
