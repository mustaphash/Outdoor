using Core.Entities;

namespace DAL.Repositories.Abstract
{
    public interface IExtrasRepository : IBaseRepository<Extras>
    {
        Task<List<Extras>> GetExtrasByIds(List<int> ids);
    }
}
