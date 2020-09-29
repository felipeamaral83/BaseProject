using BaseProject.Application.DataTransferObjects.Teste;
using BaseProject.Application.Validation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseProject.Application.Interfaces
{
    public interface ITesteAppService : IDisposable
    {
        ValidationAppResult Add(TestePostDto testePostDto);
        void Edit(TestePutDto testePutDto);
        void Delete(Guid id);
        TesteGetDto GetById(Guid id);
        Task<TesteGetDto> GetByIdAsync(Guid id);
        List<TesteGetDto> GetAllReadOnly();
    }
}
