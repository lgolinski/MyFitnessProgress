using AutoMapper;
using MyFitnessProgress.Core.Domain.Diet;
using MyFitnessProgress.Infrastructure.DTO;

namespace MyFitnessProgress.Infrastructure.AutomapperProfiles
{
    public class DietProfile : Profile
    {
        public DietProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<Unit, UnitDto>();
            CreateMap<Macro, MacroDto>();
        }
    }
}