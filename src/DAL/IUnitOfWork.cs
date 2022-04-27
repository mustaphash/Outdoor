using DAL.Repositories.Abstract;

namespace DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IAnimalRepository Animals { get; }

        Task<int> CompleteAsync();
    }
}
