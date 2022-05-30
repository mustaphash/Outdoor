using Core.Entities;
using DAL.Repositories.Abstract;

namespace DAL.Repositories
{
    public class VillaRepository : BaseRepository<Villa>, IVillaRepository
    {
        public VillaRepository(OutdoorContext context) : base(context)
        {
        }
    }
}
