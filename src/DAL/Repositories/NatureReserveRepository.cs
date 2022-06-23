using Core.Entities;
using DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class NatureReserveRepository : BaseRepository<NatureReserve>, INatureReserveRepository
    {
        private OutdoorContext _context;
        public NatureReserveRepository(OutdoorContext context) : base(context)
        {
            _context = context;
        }

#pragma warning disable CS8603
        public async Task<NatureReserve> GetReserveById(int id)
        {
            var natureReserve = await _context.NatureReserves.FirstOrDefaultAsync(n => n.Id == id);
 
            return natureReserve;
        }
#pragma warning disable CS8603 
    }
}
