using Core.Entities;
using DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class VillaRepository : BaseRepository<Villa>, IVillaRepository
    {
        private OutdoorContext _context;
        public VillaRepository(OutdoorContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Villa>> GetAllVillas()
        {
            var villa = await _context.Villas.Include(e => e.Extras).ToListAsync();

            return villa;
        }

#pragma warning disable CS8603
        public async Task<Villa> GetVillaById(int id)
        {
            var villa = await _context.Villas.Include(e => e.Extras).FirstOrDefaultAsync(v => v.Id == id);

            return villa;
        }
#pragma warning disable CS8603
    }
}
