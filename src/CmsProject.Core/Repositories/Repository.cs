using CmsProject.Core.Data;
using CmsProject.Core.DomainObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CmsProject.Core.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly DbContext _context = null;
        private DbSet<T> _entities = null;
        public Repository(DbContext context)
        {
            this._context = context;
            _entities = _context.Set<T>();
        }
        public IUnitOfWork UnitOfWork => (IUnitOfWork)_context;

        public void Adicionar(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.Entities.Add(entity);
                this._context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Atualizar(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this._context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Deletar(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.Entities.Remove(entity);
                this._context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<T>> ObterTodos()
        {
            return await this.Entities.AsNoTracking().ToListAsync();
        }

        public async Task<T> ObterPorId(Guid id)
        {
            try
            {
                return await this.Entities.FindAsync(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }
                return _entities;
            }
        }

        public void Dispose()
        {
            this._context?.Dispose();
        }

        public void Ativar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Desativar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
