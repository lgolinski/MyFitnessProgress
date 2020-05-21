using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyFitnessProgress.Infrastructure;
using MyFitnessProgress.Infrastructure.Settings;

namespace MyFitnessProgress.API.Extensions
{
    public static class SettingsExtensions
    {
        public static void BindSettings(this IServiceCollection services, IConfiguration configuration)
        {
            var settings = typeof(Sample).Assembly.ExportedTypes.Where(x =>
                typeof(ISettings).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).Select(Activator.CreateInstance).ToList();

            foreach (var setting in settings)
            {
                MethodInfo configureMethod =
                typeof(OptionsConfigurationServiceCollectionExtensions)
                .GetMethod("Configure", new Type[] { typeof(IServiceCollection), typeof(IConfiguration) })
                .MakeGenericMethod(setting.GetType());

                configureMethod.Invoke(services, new object[] { services, configuration.GetSection(nameof(setting)) });
            }
        }
    }
}