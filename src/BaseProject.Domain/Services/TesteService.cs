using BaseProject.Domain.Entities;
using BaseProject.Domain.Interfaces.Repositories;
using BaseProject.Domain.Interfaces.Services;
using BaseProject.Domain.Validation.TesteValidation;
using FluentValidation.Results;

namespace BaseProject.Domain.Services
{
    public class TesteService : ServiceBase<Teste>, ITesteService
    {
        private readonly ITesteRepository _testeRepository;

        public TesteService(ITesteRepository testeRepository) : base(testeRepository)
        {
            _testeRepository = testeRepository;
        }

        ValidationResult ITesteService.Add(Teste teste)
        {
            var validationResult = new ValidationResult();

            if (!teste.IsValid())
                return teste.ValidationResult;

            var result = new TesteFitForRegistrationValidation(_testeRepository).Validate(teste);
            if (!result.IsValid)
                validationResult = result;

            Add(teste);
            return validationResult;
        }
    }
}
