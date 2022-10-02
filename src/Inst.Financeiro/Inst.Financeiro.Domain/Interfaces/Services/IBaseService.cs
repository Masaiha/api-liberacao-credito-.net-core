using Inst.Financeiro.Domain.Models;
using System;
using System.Threading.Tasks;

namespace Inst.Financeiro.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> : IDisposable where TEntity : Entidade
    {
        //Task Adicionar(TEntity entity);

        //Task Atualizar(TEntity entity);

        //Task Remover(int id);
    }
}
