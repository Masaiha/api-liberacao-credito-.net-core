using Inst.Financeiro.CrossCutting.Enumerators;
using Inst.Financeiro.Domain.Interfaces.Repositories;
using Inst.Financeiro.Domain.Models;
using System.Threading.Tasks;

namespace Inst.Financeiro.Infra.Repositories
{
    public class TaxaRepository : ITaxaRepository
    {
        public async Task<decimal> ObterTaxaPorTipoCredito(TipoCredito tipoCredito)
        {
            await Task.CompletedTask;

            return TaxaValor.ObterValorTaxa(tipoCredito);
        }
    }
}
