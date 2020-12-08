using System;

namespace Softp.Servicos.Calculos.Domain.Entities
{
    public class JuroComposto
    {
        public double ValorInicial { get; private set; }

        public double Taxa { get; private set; }

        public int Meses { get; private set; }

        public JuroComposto(double valorInicial, double taxa, int meses)
        {
            ValorInicial = valorInicial;
            Taxa = taxa;
            Meses = meses;
        }

        public double ValorFinal => FormatarValor(ValorInicial * Math.Pow((1 + Taxa),Meses));

        private double FormatarValor(double valorInicial){
            double valorInteiro = Math.Truncate(valorInicial);
            double valorDecimal = Math.Truncate((valorInicial - valorInteiro) * 10);
            return valorInteiro + (valorDecimal/10);
        }  
    }
}