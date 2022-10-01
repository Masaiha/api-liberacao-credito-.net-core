using Inst.Financeiro.Domain.Interfaces.Repositories;
using Inst.Financeiro.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inst.Financeiro.Infra.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private List<PessoaFisica> Pessoas;

        public PessoaRepository()
        {
            Pessoas = new List<PessoaFisica>();

            Pessoas.Add(
                new PessoaFisica()
                {
                    Id = 1,
                    Nome = "João Silva",
                    Idade = 23,
                    Rg = "232.2323.23"
                });
        }

        public async Task<IEnumerable<PessoaFisica>> ListarPessoasFisicas(int pagina = 0, int limite = 10)
        {
            await Task.CompletedTask;

            return Pessoas;
        }

        public async Task<IEnumerable<PessoaJuridica>> ListarPessoasJuridicas(int pagina = 0, int limite = 10)
        {
            await Task.CompletedTask;

            return null;
        }
    }
}
