using System;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.SpaceTraders
{
    public static class ServiceConfiguration
    {
        public static void AddSpaceTradersClient(this IServiceCollection services, SpaceTradersConfig config)
        {
            if (config is null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            services.AddHttpClient<SpaceTradersClient>(client =>
            {
                client.BaseAddress = new Uri(config.StartupUrl);
            });

            services.AddSingleton<SpaceTradersClient>();
        }
    }
}