using System;

namespace Inst.Financeiro.Application.ViewModels
{
    public abstract class CreditoViewModel
    {
        public int Id { get; set; }
        public int Id_Juros { get; set; }
        public int Id_Pessoa { get; set; }
        public DateTime Data_Criacao { get; set; }
        public DateTime Data_Alteracao { get; set; }
        public bool Status { get; set; }
    }
}
