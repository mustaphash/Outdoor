using Core.Entities;
using DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
#pragma warning disable CS8603
    public class LakeRepository : BaseRepository<Lake>, ILakeRepositry
    {
        private OutdoorContext _context;
        public LakeRepository(OutdoorContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Lake>> GetAllAnimals()
        {
            var lakes = await _context.Lakes.Include(a => a.Animals).Include(e => e.Extras).ToListAsync();

            return lakes;
        }


        public async Task<Lake> GetLakeById(int id)
        {
            var lake = await _context.Lakes.Include(a => a.Animals).FirstOrDefaultAsync(l => l.Id == id);

            return lake;
        }
#pragma warning disable CS8603
    }
}
