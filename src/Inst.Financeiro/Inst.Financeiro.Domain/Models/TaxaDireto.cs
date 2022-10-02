namespace Inst.Financeiro.Domain.Models
{
    public class TaxaDireto : Taxa
    {
        public override decimal ObterTaxa()
        {
            return 20.00m;
        }
    }
}
