using System;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        void Edit(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(Guid id);
        Task<TEntity> GetByIdAsync(Guid id);
        IQueryable<TEntity> GetAllReadOnly();
    }
}
