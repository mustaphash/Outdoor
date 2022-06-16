using Infrastructure.Models;
using Infrastructure.Models.CreateModels;

namespace Infrastructure.Services.Abstract
{
    public interface IPlaceService
    {
        Task<IList<OutdoorModel>> GetAllOutdoors();

        Task<CreateOutdoorModel> CreateOutdoor(CreateOutdoorModel model);

        Task<IList<LakeModel>> GetAllLakes();

        Task<CreateLakesModel> CreateLakes(CreateLakesModel model);

        Task<IList<ParkModel>> GetAllPark();

        Task<IList<FountainModel>> GetAllFountain();

        Task<IList<LandmarkModel>> GetAllLandmarks();

        Task<IList<NatureReserveModel>> GetAllNatureReserves();

        Task<IList<VillaModel>> GetAllVilla();
    }
}
