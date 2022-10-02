using Inst.Financeiro.CrossCutting.Enumerators;
using System;
using System.Collections.Generic;

namespace Inst.Financeiro.Application.ViewModels
{
    public class CreditoPostCommand
    {
        public TipoCredito Tipo { get; set; }
        public decimal ValorCredito { get; set; }
        public int QuantidadeParcelas { get; set; }
        public DateTime DataPrimeiraParcela { get; set; }
    }

    public class CreditoViewModel
    {
        public int Id { get; set; }
        public TipoCredito Tipo { get; set; }
        public TipoCliente TipoCliente { get; set; }
        public int Taxa { get; set; }
        public DateTime DataPrimeiraParcela { get; set; }
        public int QuantidadeParcelas { get; set; }
        public IEnumerable<ParcelaViewModel> Parcelas { get; set; }
        public decimal ValorCredito { get; set; }
        public bool Aprovado { get; set; }
        public bool Status { get; set; }
    }

    public class ParcelaViewModel
    {
        public int Id { get; set; }
        public int IdCredito { get; set; }
        public int Numero { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorCalculado { get; set; }
        public DateTime Vencimento { get; set; }
    }

}
