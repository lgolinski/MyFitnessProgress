using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace MyFitnessProgress.Infrastructure.Extensions.EntityFramework
{
    public static class EFExtensions
    {
        public static void AddMappings(this ModelBuilder modelBuilder)
        {
            var configurations = typeof(Sample).Assembly.ExportedTypes.Where(x =>
                typeof(IEntityTypeConfiguration<>).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).Select(Activator.CreateInstance).ToList();

            foreach (var config in configurations)
            {
                MethodInfo applyConfigurationMethod = typeof(ModelBuilder)
                    .GetMethod("ApplyConfiguration", new Type[] { typeof(IEntityTypeConfiguration<>) });

                var type = config.GetType();
                applyConfigurationMethod.MakeGenericMethod(type);
                var bindedObj = Convert.ChangeType(config, type);
                applyConfigurationMethod.Invoke(modelBuilder, new object[] { bindedObj });
            }
        }
    }
}