using Inst.Financeiro.CrossCutting.Enumerators;
using Inst.Financeiro.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inst.Financeiro.Domain.Interfaces.Services
{
    public interface IPessoaService
    {
        Task<IEnumerable<PessoaFisica>> ListarFisica(int pagina = 0, int limite =  10);
        Task<IEnumerable<PessoaJuridica>> ListarPessoaJuridica(int pagina = 0, int limite = 10);
    }
}
