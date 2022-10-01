using AutoMapper;
using Inst.Financeiro.Application.Interfaces;
using Inst.Financeiro.Application.ViewModels;
using Inst.Financeiro.CrossCutting.Enumerators;
using Inst.Financeiro.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inst.Financeiro.Application.Services
{
    public class PessoaAppService : IPessoaAppService
    {
        private readonly IMapper _mapper;
        private readonly IPessoaService _service;

        public PessoaAppService(IPessoaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PessoaFisicaViewModel>> ListarFisica(int pagina = 0, int limite = 10)
        {
            var pessas = await _service.ListarFisica(pagina, limite);

            var teste = _mapper.Map<IEnumerable<PessoaFisicaViewModel>>(pessas);

            return teste;
        }
    }
}
