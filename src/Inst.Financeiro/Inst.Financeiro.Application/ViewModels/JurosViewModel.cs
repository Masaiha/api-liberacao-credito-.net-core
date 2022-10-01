using Inst.Financeiro.CrossCutting.Enumerators;
using System;

namespace Inst.Financeiro.Application.ViewModels
{
    public class JurosViewModelViewModel
    {
        public int Id { get; set; }
        public TipoJuros Tipo { get; set; }
        public Decimal Taxa { get; set; }
    }
}
