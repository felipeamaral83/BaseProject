using BaseProject.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BaseProject.Infra.Data.Context
{
    public class DbContextBase : DbContext, IDbContext
    {
        public DbContextBase(DbContextOptions options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public new DbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
