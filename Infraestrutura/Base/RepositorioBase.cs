using Dominio.Repositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Base
{
    public class RepositorioBase<TEntity> : IRepositorioBase<TEntity> where TEntity : class
    {

        private readonly BancoContexto _db;

        public RepositorioBase() => _db = new BancoContexto();
        public async Task Add(TEntity e)
        {
            _db.Set<TEntity>().Add(e);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(TEntity e)
        {
            _db.Set<TEntity>().Remove(e);
            await _db.SaveChangesAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
           return await _db.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> ObterTodos()
        {
            return await _db.Set<TEntity>().ToListAsync();
        }

        public async Task Update(TEntity e)
        {
            _db.Set<TEntity>().Update(e);
            await _db.SaveChangesAsync();
        }
    }
}
