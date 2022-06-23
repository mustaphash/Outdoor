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

#pragma warning disable CS8603
        public async Task<Villa> GetVillaById(int id)
        {
            var villa = await _context.Villas.FirstOrDefaultAsync(v=>v.Id == id);

            return villa;
        }
#pragma warning disable CS8603
    }
}
