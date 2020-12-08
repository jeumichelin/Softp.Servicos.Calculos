using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using Softp.Servicos.Calculos.Domain.interfaces;

namespace Softp.Servicos.Calculos.Infra.CrossCutting.ExternalServices.Services
{
    public class TaxasApiService : ITaxasApiService
    {
        private readonly HttpClient _httpClient;
        private readonly TaxaJurosSettings _settings;

        public TaxasApiService(HttpClient httpClient, TaxaJurosSettings settings)
        {
            _httpClient = httpClient;
            _settings = settings;
        }

        public async Task<double> ObterTaxaJuros()
        {
            var response = await _httpClient.GetAsync(_settings.Rotas.ObterTaxaJuros);
            if (!response.IsSuccessStatusCode)
            {
                return default;
            }
            try
            {
                var result = await response.Content.ReadAsStringAsync();
                return Double.Parse(result, NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
            }
            catch (System.Exception)
            {
               return default;
            }
        }
    }
}