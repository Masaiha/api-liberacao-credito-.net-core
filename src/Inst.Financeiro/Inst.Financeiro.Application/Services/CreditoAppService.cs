using AutoMapper;
using Inst.Financeiro.Application.Interfaces;
using Inst.Financeiro.Application.ViewModels;
using Inst.Financeiro.Domain.Interfaces.Services;
using Inst.Financeiro.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inst.Financeiro.Application.Services
{
    public class CreditoAppService : ICreditoAppService
    {
        private readonly IMapper _mapper;
        private readonly ICreditoService _service;

        public CreditoAppService(ICreditoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task Adicionar(CreditoPostCommand credito)
        {
            var _credito = _mapper.Map<Credito>(credito);
            await _service.Adicionar(_credito);
        }

        public async Task<Credito> ObterPorCliente(int id)
        {
            return _mapper.Map<Credito>(await _service.ObterPorCliente(id));
        }

    }
}
