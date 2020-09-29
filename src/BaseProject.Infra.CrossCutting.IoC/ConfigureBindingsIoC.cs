using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BaseProject.Infra.CrossCutting.IoC
{
    public static class ConfigureBindingsIoC
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            #region "Config"

            ConfigureBindingsConfig.RegisterBindings(services, configuration);

            #endregion

            #region "Repository"

            ConfigureBindingsRepository.RegisterBindings(services);

            #endregion

            #region "Service"

            ConfigureBindingsService.RegisterBindings(services);

            #endregion

            #region "AppService"

            ConfigureBindingsAppService.RegisterBindings(services);

            #endregion
        }
    }
}
