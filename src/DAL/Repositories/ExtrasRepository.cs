using Core.Entities;
using DAL.Repositories.Abstract;

namespace DAL.Repositories
{
    public class ExtrasRepository : BaseRepository<Extras>, IExtrasRepository
    {
        public ExtrasRepository(OutdoorContext outdoorContext) : base(outdoorContext)
        {
        }
    }
}
