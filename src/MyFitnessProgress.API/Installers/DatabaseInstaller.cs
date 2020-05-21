using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyFitnessProgress.Infrastructure.Mappings;
using MyFitnessProgress.Infrastructure.Services.Abstraction;
using MyFitnessProgress.Infrastructure.Services.Implementation;
using MyFitnessProgress.Infrastructure.Settings;

namespace MyFitnessProgress.API.Installers
{
    public class DatabaseInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            var databaseSettings = new DatabaseSettings();
            services.Configure<DatabaseSettings>(configuration.GetSection(nameof(DatabaseSettings)));
            configuration.GetSection(nameof(DatabaseSettings)).Bind(databaseSettings);

            services.AddDbContext<DietDbContext>(options =>
            {
                if (databaseSettings.UseInMemoryDatabase)
                    options.UseInMemoryDatabase(databaseSettings.DatabaseName);
                else
                    options.UseSqlServer(databaseSettings.ConnectionString);
            });

            services.AddScoped<IDataInitializer, DataInitializer>();
        }
    }
}