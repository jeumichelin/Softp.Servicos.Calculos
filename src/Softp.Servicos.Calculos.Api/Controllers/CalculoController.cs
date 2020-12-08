using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Softp.Servicos.Calculos.Domain.Commands;

namespace Softp.Servicos.Calculos.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculoController : ControllerBase
    {

        private readonly IMediator _mediator;

        public CalculoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Executa um cálculo de juros compostos
        /// </summary>
        [HttpPost("/calculajuros/{valorInicial}/{meses}")]
        public async Task<double> CalcularJurosCompostos([FromRoute] double valorInicial, [FromRoute] int meses) 
        {
            return await _mediator.Send(new JuroCompostoCommand(valorInicial, meses));
        }
    }
}
