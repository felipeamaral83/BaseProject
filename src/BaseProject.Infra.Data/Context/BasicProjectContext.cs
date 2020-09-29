using BaseProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BaseProject.Infra.Data.Context
{
    public partial class BasicProjectContext : DbContextBase
    {
        public DbSet<Teste> Teste { get; set; }
    }
}
