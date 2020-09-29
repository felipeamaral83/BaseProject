using BaseProject.Infra.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BaseProject.Infra.Data.Uow
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : IDbContext
    {
        protected IDbContext Context { get; set; }
        protected readonly IServiceProvider _serviceProvider;

        private bool _disposed;

        public UnitOfWork(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            Context = serviceProvider.GetService<IDbContext>();
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
