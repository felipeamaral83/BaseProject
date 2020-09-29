using BaseProject.Domain.Interfaces.Repositories;
using BaseProject.Domain.Interfaces.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public void Edit(TEntity entity)
        {
            _repository.Edit(entity);
        }

        public IQueryable<TEntity> GetAllReadOnly()
        {
            return _repository.GetAllReadOnly();
        }

        public TEntity GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
