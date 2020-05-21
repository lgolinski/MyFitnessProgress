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
            CreateMap<ProductDto, Product>().ForMember(dest => dest.UnitId, opt => opt.MapFrom(
                src => src.Unit.UnitId
            ));

            CreateMap<Unit, UnitDto>();
            CreateMap<UnitDto, Unit>();

            CreateMap<Macro, MacroDto>();
            CreateMap<MacroDto, Macro>();

        }
    }
}