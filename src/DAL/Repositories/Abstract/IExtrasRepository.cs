using Core.Entities;

namespace DAL.Repositories.Abstract
{
    public interface IExtrasRepository : IBaseRepository<Extras>
    {
        Task<List<Extras>> GetExtraByIds(List<int> ids);
    }
}
