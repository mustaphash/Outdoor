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

        public async Task<Park> GetParkById(int id)
        {
            var park = await _context.Parks.FirstOrDefaultAsync(p => p.Id == id);

#pragma warning disable CS8603 // Possible null reference return.
            return park;
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
