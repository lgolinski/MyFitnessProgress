using System.Threading.Tasks;

namespace MyFitnessProgress.Infrastructure.Services.Abstraction
{
    public interface IDataInitializer
    {
        void PrepareDatabase();
    }
}