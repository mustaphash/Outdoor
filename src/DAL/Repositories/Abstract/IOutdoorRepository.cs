using Core.Entities;

namespace DAL.Repositories.Abstract
{
    public interface IOutdoorRepository : IBaseRepository<Outdoor>
    {
        Task<Outdoor> GetOutdoorById(int id);
    }
}
