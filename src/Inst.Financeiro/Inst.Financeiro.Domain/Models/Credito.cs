using Inst.Financeiro.CrossCutting.Enumerators;
using System;

namespace Inst.Financeiro.Domain.Models
{
    public abstract class Credito : Entidade
    {
        public int Id { get; set; }
        public int Id_Juros { get; set; }
        public int Id_Pessoa { get; set; }
        public DateTime Data_Criacao { get; set; }
        public DateTime Data_Alteracao { get; set; }
        public bool Status { get; set; }
    }

    public class Juros
    {
        public int Id { get; set; }
        public TipoJuros Tipo { get; set; }
        public Decimal Taxa { get; set; }
    }
}
