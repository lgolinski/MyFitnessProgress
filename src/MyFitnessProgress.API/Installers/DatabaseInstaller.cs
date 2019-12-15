using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyFitnessProgress.API.Settings;
using MyFitnessProgress.Infrastructure.Mappings;

namespace MyFitnessProgress.API.Installers
{
    public class DatabaseInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            var databaseSettings = new DatabaseSettings();
            configuration.GetSection(nameof(DatabaseSettings)).Bind(databaseSettings);

            services.AddDbContext<DietDbContext>(options =>
            {
                if (databaseSettings.UseInMemory)
                    options.UseInMemoryDatabase(databaseSettings.DatabaseName);
                else
                    options.UseSqlServer(databaseSettings.ConnectionString);
            });
        }
    }
}