using dependencyinjection.Interfaces;
using dependencyinjection.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MyServicesCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<INotification, ConsoleNotification>();
            services.AddSingleton<INotification, LoggingNotification>();

            return services;
        }
    }
}