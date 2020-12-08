using MediatR;

namespace Softp.Servicos.Calculos.Domain.Commands
{
    public class JuroCompostoCommand : IRequest<double>{

        public double ValorInicial { get; private set; }

        public int Meses { get; private set; }

        public JuroCompostoCommand(double valorInicial, int meses)
        {
            ValorInicial = valorInicial;
            Meses = meses;
        }
    }
}