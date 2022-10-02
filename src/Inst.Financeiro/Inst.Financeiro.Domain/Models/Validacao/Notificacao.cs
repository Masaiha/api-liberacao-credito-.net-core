namespace Inst.Financeiro.Domain.Models.Validacao
{
    public class Notificacao
    {
        public Notificacao(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
