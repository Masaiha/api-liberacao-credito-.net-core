using Inst.Financeiro.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inst.Financeiro.Domain.Interfaces.Repositories
{
    public interface IPessoaRepository
    {
        Task<IEnumerable<PessoaFisica>> ListarPessoasFisicas(int pagina = 0, int limite = 10);
        Task<IEnumerable<PessoaJuridica>> ListarPessoasJuridicas(int pagina = 0, int limite = 10);
    }
}
