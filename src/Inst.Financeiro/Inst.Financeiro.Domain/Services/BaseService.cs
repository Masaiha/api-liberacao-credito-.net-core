using Inst.Financeiro.Domain.Interfaces.Services;
using Inst.Financeiro.Domain.Models;
using Inst.Financeiro.Domain.Models.Validacao;

namespace Inst.Financeiro.Domain.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : Entidade
    {
        private readonly INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }
        protected void Notificar(string message)
        {
            _notificador.Handle(new Notificacao(message));
        }

        protected bool TemNotificacao()
        {
            return _notificador.TemNotificacao();
        }

        public void Dispose(){ }
    }
}
