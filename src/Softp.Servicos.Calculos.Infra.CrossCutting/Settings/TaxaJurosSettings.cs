using Microsoft.Extensions.Configuration;

namespace Softp.Servicos.Calculos.Infra.CrossCutting
{
    public class TaxaJurosSettings
    {
        public string Endpoint { get; set; }

        public TaxaJurosSettingsRotas Rotas { get; set; }

        public TaxaJurosSettings(IConfiguration configuration)
        {
            configuration.Bind("ApiLojas", this);
        }
    }

    public class TaxaJurosSettingsRotas
    {
        public string ObterSite { get; set; }
    }
}