using Microsoft.Extensions.DependencyInjection;
using Softp.Servicos.Calculos.Infra.CrossCutting;

namespace Ecommerce.Servicos.Produtos.Infra.CrossCutting.Ioc
{
    public static class SettingsInjection
    {
        public static void AddSettings(this IServiceCollection services)
        {
            services.AddScoped<TaxaJurosSettings>();
        }
    }
}
