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

        IFountainRepository Fountains { get; }

        ILandmarkRepository Landmarks { get; }

        INatureReserveRepository NatureReserves { get; }

        IParkRepository Parks { get; }

        IVillaRepository Villas { get; }

        Task<int> CompleteAsync();
    }
}
