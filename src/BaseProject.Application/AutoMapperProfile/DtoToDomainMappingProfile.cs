using AutoMapper;
using BaseProject.Application.DataTransferObjects.Teste;
using BaseProject.Domain.Entities;

namespace BaseProject.Application.AutoMapperProfile
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {
            CreateMap<TestePostDto, Teste>();
            CreateMap<TestePutDto, Teste>();
        }
    }
}
