using Core.Entities;
using DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class OutdoorRepository : BaseRepository<Outdoor>, IOutdoorRepository
    {
        private OutdoorContext _context;
        public OutdoorRepository(OutdoorContext context) : base(context)
        {
            _context = context;
        }

#pragma warning disable CS8603
        public async Task<Outdoor> GetOutdoorById(int id)
        {
            var outdoor = await _context.Outdoors.FirstOrDefaultAsync(o => o.Id == id);
 
            return outdoor;
        }
#pragma warning restore CS8603
    }
}
