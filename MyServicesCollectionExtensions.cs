using dependencyinjection.Interfaces;
using dependencyinjection.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MyServicesCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // services.AddTransient<INotification, LoggingNotification>();
            // services.AddScoped<INotification, LoggingNotification>();
            services.AddSingleton<INotification, LoggingNotification>();

            return services;
        }
    }
}