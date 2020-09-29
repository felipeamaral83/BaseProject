using BaseProject.Infra.Data.Interfaces;

namespace BaseProject.Application.Interfaces
{
    public interface IAppServiceBase<TContext> where TContext : IDbContext
    {
        void BeginTransaction();

        void Commit();
    }
}
