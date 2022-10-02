using Inst.Financeiro.Application.ViewModels;
using Inst.Financeiro.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inst.Financeiro.Application.Interfaces
{
    public interface ICreditoAppService
    {
        Task Adicionar(CreditoPostCommand credito);
        Task<Credito> ObterPorCliente(int id);
    }
}
