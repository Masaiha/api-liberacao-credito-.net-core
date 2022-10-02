namespace Inst.Financeiro.Domain.Models
{
    public class TaxaConsignado : Taxa
    {
        public override decimal ObterTaxa()
        {
            return 10.00m;
        }
    }
}
