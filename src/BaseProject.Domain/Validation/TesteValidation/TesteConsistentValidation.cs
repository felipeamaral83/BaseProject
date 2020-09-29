using BaseProject.Domain.Entities;
using FluentValidation;

namespace BaseProject.Domain.Validation.TesteValidation
{
    public class TesteConsistentValidation : BaseValidation<Teste>
    {
        public TesteConsistentValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage(RequiredField("Nome"))
                .MaximumLength(50).WithMessage(InvalidSizeField("Nome", 50));
        }
    }
}
