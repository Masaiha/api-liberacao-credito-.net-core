using Inst.Financeiro.CrossCutting.Enumerators;
using System;
using System.Collections.Generic;

namespace Inst.Financeiro.Domain.Models
{
    public class Credito : Entidade
    {
        public int Id { get; set; }
        public TipoCredito Tipo { get; set; }

        public TipoCliente Cliente { get; set; }
        public decimal Taxa { get; private set; }
        public DateTime DataPrimeiraParcela { get; set; }
        public int QuantidadeParcelas { get; set; }
        public IEnumerable<Parcela> Parcelas { get; set; }

        public decimal ValorCredito { get; set; }
        public decimal ValorCalculado { get; private set; }
        public bool Aprovado { get; set; }
        public bool Status { get; set; }

        public void SetValorCalculado()
        {
            ValorCalculado = ValorCredito * ObterValorTaxa(Tipo);
        }

        public void SetValorTaxa()
        {
            Taxa = ObterValorTaxa(Tipo);
        }

        private decimal ObterValorTaxa(TipoCredito tipoCredito)
        {
            return TaxaValor.ObterValorTaxa(tipoCredito);
        }

        public bool ValidarValorCredito()
        {
            return Cliente == TipoCliente.PF ?
                        ValidarValorCreditoPessoaFisica() :
                        ValidarValorCreditoPessoaJuridica();
        }

        public bool ValidarValorCreditoPessoaFisica()
        {
            return ValorCredito > 1000000.00m;
        }

        public bool ValidarValorCreditoPessoaJuridica()
        {
            return ValorCredito < 15000.00m;
        }

        public bool ValidarQuantidadeParcelas()
        {
            return QuantidadeParcelas < 5 || QuantidadeParcelas > 72;
        }

        public bool ValidarDataPrimeiraParcela()
        {
            return DataPrimeiraParcela.AddDays(-15) > DateTime.Now;
        }
    }
}
