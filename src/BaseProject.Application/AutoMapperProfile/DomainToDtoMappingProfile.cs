using AutoMapper;
using BaseProject.Application.DataTransferObjects.Teste;
using BaseProject.Domain.Entities;

namespace BaseProject.Application.AutoMapperProfile
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Teste, TesteGetDto>();
        }
    }
}
