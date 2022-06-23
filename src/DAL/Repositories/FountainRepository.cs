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

#pragma warning disable CS8603
        public async Task<Fountain> GetFountainById(int id)
        {
            var fountain = await _context.Fountains.FirstOrDefaultAsync(f => f.Id == id);

            return fountain;
        }
#pragma warning disable CS8603
    }
}
