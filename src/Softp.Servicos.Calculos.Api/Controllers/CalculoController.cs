using System;
using Microsoft.AspNetCore.Mvc;

namespace Softp.Servicos.Calculos.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculoController : ControllerBase
    {
        /// <summary>
        /// Executa um cálculo de juros compostos
        /// </summary>
        [HttpPost("/calculajuros/{valorInicial}/{meses}")]
        public double CalcularJurosCompostos([FromRoute] double valorInicial, [FromRoute] int meses) 
        {
            double taxaJuros = 0.01;
            double valorFinal = valorInicial * Math.Pow((1 + taxaJuros),meses);
            return FormatarValor(valorFinal);
        }

        private double FormatarValor(double valorInicial){
            double valorInteiro = Math.Truncate(valorInicial);
            double valorDecimal = Math.Truncate((valorInicial - valorInteiro) * 10);
            return valorInteiro + (valorDecimal/10);
        }
    }
}
