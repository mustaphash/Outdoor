using DAL.Repositories.Abstract;

namespace DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IAnimalRepository Animals { get; }

        IExtrasRepository Extras { get; }

        Task<int> CompleteAsync();
    }
}
