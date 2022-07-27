using Infrastructure.Models;
using Infrastructure.Models.CreateModels;

namespace Infrastructure.Services.Abstract
{
    public interface IPlaceService
    {
        Task<IList<OutdoorModel>> GetAllOutdoors();

        Task<CreateOutdoorsModel> CreateOutdoor(CreateOutdoorsModel model);

        Task DeleteOutdoor(int outId);

        Task<IList<LakeModel>> GetAllLakes();

        Task<CreateLakesModel> CreateLakes(CreateLakesModel model);

        Task DeleteLake(int lakeId);

        Task<IList<ParkModel>> GetAllPark();

        Task<CreateParksModel> CreatePark(CreateParksModel model);

        Task DeletePark(int parkId);

        Task<IList<FountainModel>> GetAllFountain();

        Task<CreateFountainsModel> CreateFountain(CreateFountainsModel model);

        Task DeleteFountain(int fountainId);

        Task<IList<LandmarkModel>> GetAllLandmarks();

        Task<CreateLandmarksModel> CreateLandmark(CreateLandmarksModel model);

        Task DeleteLandmark(int landmarkId);

        Task<IList<NatureReserveModel>> GetAllNatureReserves();

        Task<CreateNatureReservesModel> CreateNatureReserve(CreateNatureReservesModel model);

        Task DeleteNatureReserve(int reserveId);

        Task<IList<VillaModel>> GetAllVilla();

        Task<CreateVillasModel> CreateVilla(CreateVillasModel model);

        Task DeleteVilla(int villaId);
    }
}
