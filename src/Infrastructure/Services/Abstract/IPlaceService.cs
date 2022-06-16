using Infrastructure.Models;
using Infrastructure.Models.CreateModels;

namespace Infrastructure.Services.Abstract
{
    public interface IPlaceService
    {
        Task<IList<OutdoorModel>> GetAllOutdoors();

        Task<CreateOutdoorsModel> CreateOutdoor(CreateOutdoorsModel model);

        Task<IList<LakeModel>> GetAllLakes();

        Task<CreateLakesModel> CreateLakes(CreateLakesModel model);

        Task<IList<ParkModel>> GetAllPark();

        Task<CreateParksModel> CreatePark(CreateParksModel model);

        Task<IList<FountainModel>> GetAllFountain();

        Task<CreateFountainsModel> CreateFountain(CreateFountainsModel model);

        Task<IList<LandmarkModel>> GetAllLandmarks();

        Task<CreateLandmarksModel> CreateLandmark(CreateLandmarksModel model);

        Task<IList<NatureReserveModel>> GetAllNatureReserves();

        Task<CreateNatureReservesModel> CreateNatureReserve(CreateNatureReservesModel model);

        Task<IList<VillaModel>> GetAllVilla();

        Task<CreateVillasModel> CreateVilla(CreateVillasModel model);
    }
}
