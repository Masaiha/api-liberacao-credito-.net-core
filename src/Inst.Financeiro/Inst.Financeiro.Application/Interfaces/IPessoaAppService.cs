using Inst.Financeiro.Application.ViewModels;
using Inst.Financeiro.CrossCutting.Enumerators;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inst.Financeiro.Application.Interfaces
{
    public interface IPessoaAppService
    {
        Task<IEnumerable<PessoaFisicaViewModel>> ListarFisica(int pagina = 0, int limite = 10);
    }
}
