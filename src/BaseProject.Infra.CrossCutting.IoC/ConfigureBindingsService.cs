using BaseProject.Domain.Interfaces.Services;
using BaseProject.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BaseProject.Infra.CrossCutting.IoC
{
    public static class ConfigureBindingsService
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            services.AddScoped<ITesteService, TesteService>();
        }
    }
}
