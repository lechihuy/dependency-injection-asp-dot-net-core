using dependencyinjection.Interfaces;
using dependencyinjection.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MyServicesCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ConsoleNotification>();
            services.AddSingleton<LoggingNotification>();

            return services;
        }
    }
}