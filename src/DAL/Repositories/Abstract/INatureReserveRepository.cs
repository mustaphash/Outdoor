using Core.Entities;

namespace DAL.Repositories.Abstract
{
    public interface INatureReserveRepository : IBaseRepository<NatureReserve>
    {
        Task<NatureReserve> GetReserveById(int id);

        Task<List<NatureReserve>> GetAllReserves();
    }
}
