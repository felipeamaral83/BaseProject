using BaseProject.Domain.Interfaces.Repositories;
using BaseProject.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
        where TEntity : class
        where TContext : IDbContext
    {
        private DbSet<TEntity> DbSet;
        protected readonly TContext Context;

        public RepositoryBase(TContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Edit(TEntity entity)
        {
            var local = DbSet.Local.FirstOrDefault();
            if (local != null)
            {
                var entryLocal = Context.Entry(local);
                entryLocal.State = EntityState.Detached;
            }

            var entry = Context.Entry(entity);
            DbSet.Attach(entity);
            entry.State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public virtual TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual IQueryable<TEntity> GetAllReadOnly()
        {
            return DbSet.AsNoTracking();
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
