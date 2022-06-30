using Core.Entities;

namespace DAL.Repositories.Abstract
{
    public interface IAnimalRepository : IBaseRepository<Animal>
    {
        Task<List<Animal>> GetAnimalsByIds(List<int> ids);
    }
}
