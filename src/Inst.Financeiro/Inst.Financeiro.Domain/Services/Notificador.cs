using Inst.Financeiro.Domain.Interfaces.Services;
using Inst.Financeiro.Domain.Models.Validacao;
using System.Collections.Generic;
using System.Linq;

namespace Inst.Financeiro.Domain.Services
{
    public class Notificador : INotificador
    {
        private List<Notificacao> _notificacoes;

        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public string[] ObterNotificacoesToArray()
        {
            string[] teste = new string[_notificacoes.Count()];

            int index = 0;
            foreach (var notificacao in _notificacoes)
            {
                teste[index] = notificacao.Message;
                index++;
            }

            return teste;
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}
