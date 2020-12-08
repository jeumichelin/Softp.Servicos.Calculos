using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Softp.Servicos.Calculos.Domain.Entities;
using Softp.Servicos.Calculos.Domain.interfaces;

namespace Softp.Servicos.Calculos.Domain.Commands
{
    public class JuroCompostoCommandHandler : IRequestHandler<JuroCompostoCommand, double>
    {
        private readonly ITaxasApiService _apiService;

        public JuroCompostoCommandHandler(ITaxasApiService apiService)
        {
            _apiService = apiService;
        }

        async Task<double> IRequestHandler<JuroCompostoCommand, double>.Handle(JuroCompostoCommand request, CancellationToken cancellationToken)
        {
           var taxaJuros = await _apiService.ObterTaxaJuros();         
           var juroComposto =  new JuroComposto(request.ValorInicial,taxaJuros,request.Meses);
           return juroComposto.ValorFinal;
        }          
    }
}