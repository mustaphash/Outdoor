using Core.Entities;
using DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class FountainRepository : BaseRepository<Fountain>, IFountainRepository
    {
        private OutdoorContext _context;
        public FountainRepository(OutdoorContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Fountain>> GetAllFountains()
        {
            var fountain = await _context.Fountains.Include(e => e.Extras).Include(w => w.WaterType).ToListAsync();

            return fountain;
        }

#pragma warning disable CS8603
        public async Task<Fountain> GetFountainById(int id)
        {
            var fountain = await _context.Fountains.Include(e => e.Extras).FirstOrDefaultAsync(f => f.Id == id);

            return fountain;
        }
#pragma warning disable CS8603
    }
}
