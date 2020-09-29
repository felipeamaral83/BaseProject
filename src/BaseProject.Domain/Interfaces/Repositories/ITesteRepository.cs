using BaseProject.Domain.Entities;

namespace BaseProject.Domain.Interfaces.Repositories
{
    public interface ITesteRepository : IRepositoryBase<Teste>
    {
        Teste GetByName(string name);
    }
}
