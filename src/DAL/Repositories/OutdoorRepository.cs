using Core.Entities;
using DAL.Repositories.Abstract;

namespace DAL.Repositories
{
    public class OutdoorRepository : BaseRepository<Outdoor>, IOutdoorRepository
    {
        public OutdoorRepository(OutdoorContext context) : base(context)
        {
        }
    }
}
