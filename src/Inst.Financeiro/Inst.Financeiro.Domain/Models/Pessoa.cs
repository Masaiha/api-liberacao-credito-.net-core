namespace Inst.Financeiro.Domain.Models
{
    public abstract class Pessoa : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
