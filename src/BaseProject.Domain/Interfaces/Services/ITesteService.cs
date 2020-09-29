using BaseProject.Domain.Entities;
using FluentValidation.Results;

namespace BaseProject.Domain.Interfaces.Services
{
    public interface ITesteService : IServiceBase<Teste>
    {
        new ValidationResult Add(Teste teste);
    }
}
