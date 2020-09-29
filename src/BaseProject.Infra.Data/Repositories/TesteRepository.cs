using BaseProject.Domain.Entities;
using BaseProject.Domain.Interfaces.Repositories;
using BaseProject.Infra.Data.Context;
using System.Linq;

namespace BaseProject.Infra.Data.Repositories
{
    public class TesteRepository : RepositoryBase<Teste, BasicProjectContext>, ITesteRepository
    {
        public TesteRepository(BasicProjectContext context) : base(context) { }

        public Teste GetByName(string name)
        {
            var teste = Context.Teste.Where(x => x.Name == name).FirstOrDefault();
            return teste;
        }
    }
}
