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

        public async Task<Animal> GetAnimalById(int id)
        {
            var animal = await _context.Animals.FirstOrDefaultAsync(a => a.Id == id);
            //Where List<Animals> Contains Animal.Id

            return animal;
        }

        public async Task<List<Animal>> GetAnimalsByIds(List<int> ids)
        {
            var animal = await _context.Animals.Where(a => ids.Contains(a.Id)).ToListAsync();

            return animal;
        }
    }
}
