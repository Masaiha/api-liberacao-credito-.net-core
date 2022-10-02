namespace Inst.Financeiro.Domain.Models
{
    public class TaxaImobiliario : Taxa
    {
        public override decimal ObterTaxa()
        {
            return 9.00m;
        }
    }
}
