using Core.Entities;

namespace DAL.Repositories.Abstract
{
    public interface IWaterTypeRepository : IBaseRepository<WaterType>
    {
        Task<WaterType> GetWaterTypeById(int id);
    }
}
