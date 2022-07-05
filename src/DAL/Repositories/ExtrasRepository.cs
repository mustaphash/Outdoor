using Core.Entities;
using DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ExtrasRepository : BaseRepository<Extras>, IExtrasRepository
    {
        private OutdoorContext _context;
        public ExtrasRepository(OutdoorContext outdoorContext) : base(outdoorContext)
        {
            _context = outdoorContext;
        }

        public async Task<List<Extras>> GetExtrasByIds(List<int> ids)
        {
            var extras = await _context.Extras.Where(e => ids.Contains(e.Id)).ToListAsync();

            return extras;
        }
    }
}
