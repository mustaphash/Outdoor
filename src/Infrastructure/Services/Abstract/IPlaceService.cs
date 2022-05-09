using Infrastructure.Models;

namespace Infrastructure.Services.Abstract
{
    public interface IPlaceService
    {
        Task<List<OutdoorModel>> GetAllOutdoors();
    }
}
