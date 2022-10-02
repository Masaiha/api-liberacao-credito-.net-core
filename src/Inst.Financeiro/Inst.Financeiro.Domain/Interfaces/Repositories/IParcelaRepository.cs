using Inst.Financeiro.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inst.Financeiro.Domain.Interfaces.Repositories
{
    public interface IParcelaRepository
    {
        Task Adicionar(Parcela parcela);
    }
}
