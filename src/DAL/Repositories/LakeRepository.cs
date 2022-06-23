using Core.Entities;
using DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class LakeRepository : BaseRepository<Lake>, ILakeRepositry
    {
        private OutdoorContext _context;
        public LakeRepository(OutdoorContext context) : base(context)
        {
            _context = context;
        }

#pragma warning disable CS8603 
        public async Task<Lake> GetLakeById(int id)
        {
            var lake = await _context.Lakes.FirstOrDefaultAsync(l => l.Id == id);

            return lake;
        }
#pragma warning disable CS8603
    }
}
