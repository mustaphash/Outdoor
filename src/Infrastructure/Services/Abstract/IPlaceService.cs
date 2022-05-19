using Infrastructure.Models;

namespace Infrastructure.Services.Abstract
{
    public interface IPlaceService
    {
        Task<IList<OutdoorModel>> GetAllOutdoors();

        Task<CreateOutdoorModel> CreateOutdoor(CreateOutdoorModel model);

        Task<IList<LakeModel>> GetAllLakes();
    }
}
