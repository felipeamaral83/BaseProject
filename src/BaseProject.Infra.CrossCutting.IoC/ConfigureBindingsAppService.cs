using BaseProject.Application.Interfaces;
using BaseProject.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BaseProject.Infra.CrossCutting.IoC
{
    public static class ConfigureBindingsAppService
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            services.AddScoped<ITesteAppService, TesteAppService>();
        }
    }
}
