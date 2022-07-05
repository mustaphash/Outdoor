using Core.Entities;

namespace DAL.Repositories.Abstract
{
    public interface IVillaRepository : IBaseRepository<Villa>
    {
        Task<Villa> GetVillaById(int id);

        Task<List<Villa>> GetAllVillas();
    }
}
