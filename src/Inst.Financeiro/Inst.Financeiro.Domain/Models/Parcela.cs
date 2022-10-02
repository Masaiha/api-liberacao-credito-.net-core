using System;

namespace Inst.Financeiro.Domain.Models
{
    public class Parcela
    {
        public Guid Id { get; set; }
        public int IdCredito { get; set; }
        public int Numero { get; set; }
        public decimal ValorCalculado { get; set; }
        public DateTime Vencimento { get; set; }
    }
}
