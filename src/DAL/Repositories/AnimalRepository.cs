using Core.Entities;
using DAL.Repositories.Abstract;

namespace DAL.Repositories
{
    public class AnimalRepository : BaseRepository<Animal>, IAnimalRepository
    {
        public AnimalRepository(OutdoorContext context) : base(context)
        {
        }
    }
}
