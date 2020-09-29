using FluentValidation;

namespace BaseProject.Domain.Validation
{
    public abstract class BaseValidation<TEntity> : AbstractValidator<TEntity>
    {
        protected string RequiredField(string field) => $"O campo {field} é obrigatório.";
        protected string InvalidSizeField(string field, int size) => $"O campo {field} deve possuir no máximo {size} caracteres.";
    }
}
