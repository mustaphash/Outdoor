using Core.Entities;
using DAL.Repositories.Abstract;

namespace DAL.Repositories
{
    public class WaterTypeRepository : BaseRepository<WaterType>, IWaterTypeRepository
    {
        public WaterTypeRepository(OutdoorContext context) : base(context)
        {
        }
    }
}
