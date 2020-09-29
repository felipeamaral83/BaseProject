using System;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Edit(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(Guid id);
        Task<TEntity> GetByIdAsync(Guid id);
        IQueryable<TEntity> GetAllReadOnly();
        void Dispose();
    }
}
