using Inst.Financeiro.Domain.Interfaces.Repositories;
using Inst.Financeiro.Domain.Models;
using Inst.Financeiro.Infra.Context;
using System.Threading.Tasks;

namespace Inst.Financeiro.Infra.Repositories
{
    public class ParcelaRepository : IParcelaRepository
    {
        public async Task Adicionar(Parcela parcela)
        {
            BancoDados.TbParcelasAdicionar(parcela);
        }
    }
}
