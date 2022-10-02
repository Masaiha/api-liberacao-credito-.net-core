namespace Inst.Financeiro.Domain.Models
{
    public class TaxaPessoaFisica : Taxa
    {
        public override decimal ObterTaxa()
        {
            return 5.00m;
        }
    }
}
