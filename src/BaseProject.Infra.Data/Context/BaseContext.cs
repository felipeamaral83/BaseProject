using Microsoft.EntityFrameworkCore;

namespace BaseProject.Infra.Data.Context
{
    public partial class BasicProjectContext : DbContextBase
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public BasicProjectContext(DbContextOptions options) : base(options)
        {
        }
    }
}
