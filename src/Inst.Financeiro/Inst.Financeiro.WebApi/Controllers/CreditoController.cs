using Inst.Financeiro.Application.Interfaces;
using Inst.Financeiro.Application.ViewModels;
using Inst.Financeiro.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Inst.Financeiro.WebApi.Controllers
{
    [Route("[controller]")]
    public class CreditoController : MainController
    {
        private readonly ICreditoAppService _appService;

        public CreditoController(ICreditoAppService appService, INotificador notificador) : base(notificador)
        {
            _appService = appService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Adicionar(CreditoPostCommand credito)
        {
            await _appService.Adicionar(credito);

            return CustomResponse();
        }

        [HttpGet("obter-por-id-cliente")]
        public async Task<IActionResult> ObterPorIdCliente(int id)
        {
            var clientes = await _appService.ObterPorCliente(id);

            return CustomResponse(clientes);
        }
    }
}
