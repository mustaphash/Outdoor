using Core.Entities;
using DAL.Repositories.Abstract;

namespace DAL.Repositories
{
    public class FountainRepository : BaseRepository<Fountain>, IFountainRepository
    {
        public FountainRepository(OutdoorContext context) : base(context)
        {
        }
    }
}
