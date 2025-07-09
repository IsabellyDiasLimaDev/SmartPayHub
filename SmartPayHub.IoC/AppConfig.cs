using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartPayHub.Configuration;

namespace SmartPayHub.IoC
{
    public static class AppConfig
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Registra serviços de autenticação
            services.AddJwtAuthentication(configuration);
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            // Aqui você pode registrar outros serviços da sua aplicação
            // services.AddScoped<IErrorNotifier, ErrorNotifier>();
            // services.AddScoped<IMerchantRepository, MerchantRepository>();
            // services.AddScoped<IMerchantUseCase, MerchantUseCase>();
            // etc.

            return services;
        }
    }
}
