using Core.Entities;

namespace DAL.Repositories.Abstract
{
    public interface IFountainRepository : IBaseRepository<Fountain>
    {
        Task<Fountain> GetFountainById(int id);

        Task<List<Fountain>> GetAllFountains();
    }
}
