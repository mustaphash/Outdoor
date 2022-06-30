using Core.Entities;
using DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class AnimalRepository : BaseRepository<Animal>, IAnimalRepository
    {
        private OutdoorContext _context;
        public AnimalRepository(OutdoorContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Animal>> GetAnimalsByIds(List<int> ids)
        {
            var animal = await _context.Animals.Where(a => ids.Contains(a.Id)).ToListAsync();

            return animal;
        }
    }
}
