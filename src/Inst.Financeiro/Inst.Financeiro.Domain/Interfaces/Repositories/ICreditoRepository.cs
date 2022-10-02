using Inst.Financeiro.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inst.Financeiro.Domain.Interfaces.Repositories
{
    public interface ICreditoRepository
    {
        Task Adicionar(Credito credito);
        Task<Credito> ObterPorCliente(int id);
        Task<int> ObterUltimoId();
    }
}
