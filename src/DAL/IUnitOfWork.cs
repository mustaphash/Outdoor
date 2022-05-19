using DAL.Repositories.Abstract;

namespace DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IAnimalRepository Animals { get; }

        IExtrasRepository Extras { get; }

        IWaterTypeRepository WaterTypes { get; }

        IOutdoorRepository Outdoors { get; }

        ILakeRepositry Lakes { get; }

        Task<int> CompleteAsync();
    }
}
