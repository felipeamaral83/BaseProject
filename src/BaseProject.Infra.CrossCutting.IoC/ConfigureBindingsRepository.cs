using BaseProject.Domain.Interfaces.Repositories;
using BaseProject.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BaseProject.Infra.CrossCutting.IoC
{
    public class ConfigureBindingsRepository
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            services.AddScoped<ITesteRepository, TesteRepository>();
        }
    }
}
