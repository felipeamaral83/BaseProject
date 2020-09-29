using BaseProject.Domain.Validation.TesteValidation;
using FluentValidation.Results;
using System;

namespace BaseProject.Domain.Entities
{
    public class Teste
    {
        public Teste()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public ValidationResult ValidationResult { get; private set; }

        public bool IsValid()
        {
            var supervisor = new TesteConsistentValidation();
            ValidationResult = supervisor.Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
