using Inst.Financeiro.Domain.Models.Validacao;
using System.Collections.Generic;

namespace Inst.Financeiro.Domain.Interfaces.Services
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        string[] ObterNotificacoesToArray();
        void Handle(Notificacao notificacao);
    }
}
