using Microsoft.Extensions.Configuration;

namespace Softp.Servicos.Calculos.Infra.CrossCutting
{
    public class TaxaJurosSettings
    {
        public string Endpoint { get; set; }

        public TaxaJurosSettingsRotas Rotas { get; set; }

        public TaxaJurosSettings(IConfiguration configuration)
        {
            configuration.Bind("ApiTaxas", this);
        }
    }

    public class TaxaJurosSettingsRotas
    {
        public string ObterTaxaJuros { get; set; }
    }
}