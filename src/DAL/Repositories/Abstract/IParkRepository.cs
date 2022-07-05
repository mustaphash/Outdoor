using Core.Entities;

namespace DAL.Repositories.Abstract
{
    public interface IParkRepository : IBaseRepository<Park>
    {
        Task<Park> GetParkById(int id);

        Task<List<Park>> GetAllParks();
    }
}
