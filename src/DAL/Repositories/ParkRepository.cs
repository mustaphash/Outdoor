using Core.Entities;
using DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ParkRepository : BaseRepository<Park>, IParkRepository
    {
        private OutdoorContext _context;
        public ParkRepository(OutdoorContext context) : base(context)
        {
            _context = context;
        }

#pragma warning disable CS8603
        public async Task<Park> GetParkById(int id)
        {
            var park = await _context.Parks.FirstOrDefaultAsync(p => p.Id == id);

            return park;
        }
#pragma warning disable CS8603
    }
}
