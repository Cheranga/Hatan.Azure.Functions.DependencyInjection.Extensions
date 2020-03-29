using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Hatan.Azure.Functions.DependencyInjection.Extensions
{
    public static class ServiceExtensions
    {

        public static void RegisterConfiguration<TCustomConfiguration>(this IServiceCollection services, string sectionName, ServiceLifetime serviceLifetime) where TCustomConfiguration : class, ICustomApplicationSetting, new()
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (string.IsNullOrWhiteSpace(sectionName))
            {
                throw new ArgumentNullException(nameof(sectionName));
            }

            services.AddOptions<TCustomConfiguration>().Configure<IConfiguration>((customSetting, configuration) =>
            {
                configuration.GetSection(sectionName).Bind(customSetting);
            });

            services.Add(new ServiceDescriptor(typeof(TCustomConfiguration), provider =>
            {
                var options = provider.GetRequiredService<IOptions<TCustomConfiguration>>();
                return options.Value;
            }, serviceLifetime));
        }

        public static void RegisterConfiguration<TCustomConfiguration>(this IServiceCollection services, ServiceLifetime serviceLifetime) where TCustomConfiguration : class, ICustomApplicationSetting, new()
        {
            services.RegisterConfiguration<TCustomConfiguration>(typeof(TCustomConfiguration).Name, serviceLifetime);
        }
    }
}
