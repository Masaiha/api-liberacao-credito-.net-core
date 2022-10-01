using Inst.Financeiro.CrossCutting.Enumerators;
using Inst.Financeiro.Domain.Interfaces.Repositories;
using Inst.Financeiro.Domain.Interfaces.Services;
using Inst.Financeiro.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inst.Financeiro.Domain.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _repository;

        public PessoaService(IPessoaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<PessoaFisica>> ListarFisica(int pagina = 0, int limite = 10)
        {
            return await _repository.ListarPessoasFisicas(pagina, limite);
        }

        public async Task<IEnumerable<PessoaJuridica>> ListarPessoaJuridica(int pagina = 0, int limite = 10)
        {
            return await _repository.ListarPessoasJuridicas(pagina, limite);

        }
    }
}
