using AutoMapper;
using BaseProject.Application.AutoMapperProfile;
using BaseProject.Domain.Interfaces.Repositories;
using BaseProject.Domain.Interfaces.Services;
using BaseProject.Domain.Services;
using BaseProject.Infra.Data.Context;
using BaseProject.Infra.Data.Interfaces;
using BaseProject.Infra.Data.Repositories;
using BaseProject.Infra.Data.Uow;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BaseProject.Infra.CrossCutting.IoC
{
    public class ConfigureBindingsConfig
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddEntityFrameworkSqlServer()
                .AddDbContext<BasicProjectContext>(
                        options => options.UseSqlServer(configuration.GetConnectionString("dbserver"))
                );

            services.AddScoped<IDbContext, BasicProjectContext>();
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<,>));
            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));

            var mapperConfiguration = new MapperConfiguration(x =>
            {
                x.AddProfile(new DomainToDtoMappingProfile());
                x.AddProfile(new DtoToDomainMappingProfile());
            });

            var mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
