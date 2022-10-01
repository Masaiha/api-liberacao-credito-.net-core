using Inst.Financeiro.Application.Interfaces;
using Inst.Financeiro.CrossCutting.Enumerators;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Inst.Financeiro.WebApi.Controllers
{
    [Route("[controller]")]
    public class PessoaController : MainController
    {
        private readonly IPessoaAppService _appService;

        public PessoaController(IPessoaAppService appService)
        {
            _appService = appService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> ListarFisica(int pagina = 0, int limite = 10)
        {
            var pessoas = await _appService.ListarFisica(pagina, limite);
            
            return CustomResponse(pessoas);
        }
    }
}
