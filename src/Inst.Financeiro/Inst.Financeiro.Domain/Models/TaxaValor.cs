using Inst.Financeiro.CrossCutting.Enumerators;

namespace Inst.Financeiro.Domain.Models
{
    public static class TaxaValor
    {
        public static decimal ObterValorTaxa(TipoCredito tipo)
        {
            switch (tipo)
            {
                case TipoCredito.Consignado:
                    return new TaxaConsignado().ObterTaxa();
                case TipoCredito.Direto:
                    return new TaxaDireto().ObterTaxa();
                case TipoCredito.Imobiliario:
                    return new TaxaImobiliario().ObterTaxa();
                case TipoCredito.PessoaFisica:
                    return new TaxaPessoaFisica().ObterTaxa();
                case TipoCredito.PessoaJuridica:
                    return new TaxaPessoaJuridica().ObterTaxa();
                default:
                    return new TaxaConsignado().ObterTaxa();
            }
        }
    }
}
