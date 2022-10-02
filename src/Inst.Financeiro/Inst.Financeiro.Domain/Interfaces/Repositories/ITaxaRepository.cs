using Inst.Financeiro.CrossCutting.Enumerators;
using System.Threading.Tasks;

namespace Inst.Financeiro.Domain.Interfaces.Repositories
{
    public interface ITaxaRepository
    {
        Task<decimal> ObterTaxaPorTipoCredito(TipoCredito tipoCredito);
    }
}
