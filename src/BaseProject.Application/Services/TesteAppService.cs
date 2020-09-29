using BaseProject.Application.DataTransferObjects.Teste;
using BaseProject.Application.Interfaces;
using BaseProject.Application.Validation;
using BaseProject.Domain.Entities;
using BaseProject.Domain.Interfaces.Services;
using BaseProject.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Application.Services
{
    public class TesteAppService : AppServiceBase<BasicProjectContext>, ITesteAppService
    {
        private readonly ITesteService _testeService;

        public TesteAppService(
            IServiceProvider serviceProvider,
            ITesteService testeService) : base(serviceProvider)
        {
            _testeService = testeService;
        }

        public ValidationAppResult Add(TestePostDto testePostDto)
        {
            var teste = _mapper.Map<Teste>(testePostDto);

            BeginTransaction();

            var validationResult = _testeService.Add(teste);

            if (!validationResult.IsValid)
                return DomainToApplicationResult(validationResult);

            Commit();

            return DomainToApplicationResult(validationResult);
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Edit(TestePutDto testePutDto)
        {
            throw new NotImplementedException();
        }

        public List<TesteGetDto> GetAllReadOnly()
        {
            var query = _testeService.GetAllReadOnly();
            var testeGetDto = _mapper.Map<List<TesteGetDto>>(query.ToList());
            return testeGetDto;
        }

        public TesteGetDto GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TesteGetDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _testeService.Dispose();
        }
    }
}
