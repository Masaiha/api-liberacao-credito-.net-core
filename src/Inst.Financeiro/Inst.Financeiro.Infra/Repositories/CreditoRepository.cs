using Inst.Financeiro.Domain.Interfaces.Repositories;
using Inst.Financeiro.Domain.Models;
using Inst.Financeiro.Infra.Context;
using System.Threading.Tasks;

namespace Inst.Financeiro.Infra.Repositories
{
    public class CreditoRepository : ICreditoRepository
    {
        public async Task Adicionar(Credito credito)
        {
            await Task.CompletedTask;

            BancoDados.TbCreditoAdicionar(credito);

            return;
        }

        public async Task<Credito> ObterPorCliente(int id)
        {
            await Task.CompletedTask;

            var credito = BancoDados.TbCreditos(id);

            return credito;
        }

        public async Task<int> ObterUltimoId()
        {
            await Task.CompletedTask;

            return BancoDados.ProximoIdCredito();
        }
    }
}
