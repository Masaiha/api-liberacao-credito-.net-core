namespace Inst.Financeiro.Domain.Models
{
    public class TaxaPessoaJuridica : Taxa
    {
        public override decimal ObterTaxa()
        {
            return 3.00m;
        }
    }
}
