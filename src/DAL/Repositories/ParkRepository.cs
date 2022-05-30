using Core.Entities;
using DAL.Repositories.Abstract;

namespace DAL.Repositories
{
    public class ParkRepository : BaseRepository<Park>, IParkRepository
    {
        public ParkRepository(OutdoorContext context) : base(context)
        {
        }
    }
}
