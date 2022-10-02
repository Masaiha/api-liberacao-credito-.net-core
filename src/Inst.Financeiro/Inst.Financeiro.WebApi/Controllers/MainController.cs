using Inst.Financeiro.Domain.Interfaces.Services;
using Inst.Financeiro.Domain.Models.Validacao;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace Inst.Financeiro.WebApi.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        private readonly INotificador _notificador;

        protected MainController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected IActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(result);
            }

            return BadRequest(new ValidationProblemDetails(new Dictionary<string, string[]>
            {
                { "Mensagens", _notificador.ObterNotificacoesToArray() }
            }));
        }

        protected IActionResult CustomResponse(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);

            foreach (var erro in erros)
            {
                AdicioanrErros(new Notificacao(erro.ErrorMessage));
            }

            return CustomResponse();
        }

        protected bool OperacaoValida()
        {
            return !_notificador.TemNotificacao();
        }

        protected void AdicioanrErros(Notificacao notificacao)
        {
            _notificador.Handle(notificacao);
        }

    }
}
