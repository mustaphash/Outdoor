using Core.Entities;
using DAL.Repositories.Abstract;

namespace DAL.Repositories
{
    public class NatureReserveRepository : BaseRepository<NatureReserve>, INatureReserveRepository
    {
        public NatureReserveRepository(OutdoorContext context) : base(context)
        {
        }
    }
}
