using System.Threading.Tasks;

namespace Softp.Servicos.Calculos.Domain.interfaces
{
    public interface ITaxasApiService
    {
        Task<double> ObterTaxaJuros ();
    }
}
