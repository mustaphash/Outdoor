using Core.Entities;
using DAL.Repositories.Abstract;

namespace DAL.Repositories
{
    public class LakeRepository : BaseRepository<Lake>, ILakeRepositry
    {
        public LakeRepository(OutdoorContext context) : base(context)
        {
        }
    }
}
