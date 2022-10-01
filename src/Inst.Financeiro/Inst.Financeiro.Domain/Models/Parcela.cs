using System;

namespace Inst.Financeiro.Domain.Models
{
    public class Parcela : Entidade
    {
        public int Id { get; set; }
        public int Id_Credito { get; set; }
        public int Numero { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime Data_Criacao { get; set; }
        public DateTime Data_Alteracao { get; set; }
    }
}
