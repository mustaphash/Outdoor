using Core.Entities;
using DAL.Repositories.Abstract;

namespace DAL.Repositories
{
    public class LandmarkRepository : BaseRepository<Landmark>, ILandmarkRepository
    {
        public LandmarkRepository(OutdoorContext context) : base(context)
        {
        }
    }
}
