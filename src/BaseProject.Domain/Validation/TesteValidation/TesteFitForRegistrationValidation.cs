using BaseProject.Domain.Entities;
using BaseProject.Domain.Interfaces.Repositories;
using FluentValidation;

namespace BaseProject.Domain.Validation.TesteValidation
{
    public class TesteFitForRegistrationValidation : BaseValidation<Teste>
    {
        private readonly ITesteRepository _testeRepository;

        public TesteFitForRegistrationValidation(ITesteRepository testeRepository)
        {
            _testeRepository = testeRepository;
            
            RuleFor(x => x.Name).Must(name =>
            {
                return _testeRepository.GetByName(name) == null;
            }).WithMessage(x => $"Teste {x.Name} já cadastrado.");
        }
    }
}
