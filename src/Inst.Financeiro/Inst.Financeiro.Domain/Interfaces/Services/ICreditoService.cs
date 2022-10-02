using Inst.Financeiro.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inst.Financeiro.Domain.Interfaces.Services
{
    public interface ICreditoService
    {
        Task Adicionar(Credito credito);
        Task<Credito> ObterPorCliente(int id);
    }
}
