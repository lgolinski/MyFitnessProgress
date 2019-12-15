using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyFitnessProgress.Infrastructure.Repositories.Abstraction;
using MyFitnessProgress.Infrastructure.Repositories.Implementation;
using MyFitnessProgress.Infrastructure.Services.Abstraction;
using MyFitnessProgress.Infrastructure.Services.Implementation;

namespace MyFitnessProgress.API.Installers
{
    public class DIInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductsService, ProductsService>();
            services.AddScoped<IProductRepository, InMemoryProductRepository>();
        }
    }
}