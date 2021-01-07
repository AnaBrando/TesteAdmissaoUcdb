using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorio
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        Task<List<TEntity>> ObterTodos();

        Task<TEntity> GetById(int id);

        Task Add(TEntity e);

        Task Update(TEntity e);

        Task Delete(TEntity e);


    }
}
