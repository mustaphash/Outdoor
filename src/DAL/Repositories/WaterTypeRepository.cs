using Core.Entities;
using DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class WaterTypeRepository : BaseRepository<WaterType>, IWaterTypeRepository
    {
        private OutdoorContext _context;
        public WaterTypeRepository(OutdoorContext context) : base(context)
        {
            _context = context;
        }

#pragma warning disable CS8603
        public async Task<WaterType> GetWaterTypeById(int id)
        {
            var water = await _context.WaterTypes.FirstOrDefaultAsync(w => w.Id == id);
 
            return water; 
        }
#pragma warning disable CS8603
    }
}
