using Core.Entities;
using DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class LandmarkRepository : BaseRepository<Landmark>, ILandmarkRepository
    {
        private OutdoorContext _context;
        public LandmarkRepository(OutdoorContext context) : base(context)
        {
            _context = context;
        }

#pragma warning disable CS8603
        public async Task<Landmark> GetLandmarkById(int id)
        {
            var landmark = await _context.Landmarks.FirstOrDefaultAsync(l => l.Id == id);

            return landmark;
        }
#pragma warning restore CS8603
    }
}
