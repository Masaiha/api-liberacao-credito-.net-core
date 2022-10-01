using Inst.Financeiro.Application.Interfaces;
using Inst.Financeiro.CrossCutting.Enumerators;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Inst.Financeiro.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
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
            
            return Ok(pessoas);
        }
    }
}
