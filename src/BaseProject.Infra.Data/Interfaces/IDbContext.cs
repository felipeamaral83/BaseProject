using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BaseProject.Infra.Data.Interfaces
{
    public interface IDbContext
    {
        DbSet<T> Set<T>() where T : class;

        EntityEntry<T> Entry<T>(T entity) where T : class;

        int SaveChanges();

        void Dispose();
    }
}
