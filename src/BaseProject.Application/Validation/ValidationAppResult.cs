using System.Collections.Generic;

namespace BaseProject.Application.Validation
{
    public class ValidationAppResult
    {
        private readonly List<ValidationAppError> _errors = new List<ValidationAppError>();

        public string Mensagem { get; set; }

        public bool IsValid
        {
            get { return _errors.Count == 0; }
            set {
            }
        }

        public ICollection<ValidationAppError> Erros => _errors;
    }
}
