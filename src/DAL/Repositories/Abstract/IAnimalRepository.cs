using Core.Entities;

namespace DAL.Repositories.Abstract
{
    public interface IAnimalRepository : IBaseRepository<Animal>
    {
        Task<Animal> GetAnimalById(int id);
        Task<List<Animal>> GetAnimalsByIds(List<int> ids);
    }
}
