using DAL;
using Infrastructure.Models;
using Infrastructure.Models.CreateModels;
using Infrastructure.Services.Abstract;

namespace Infrastructure.Services
{
    public class PlaceService : IPlaceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PlaceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //Outdoor
        public async Task<CreateOutdoorModel> CreateOutdoor(CreateOutdoorModel model)
        {
            var outdoors = model.ToOutdoor();
            await _unitOfWork.Outdoors.Add(outdoors);
            await _unitOfWork.CompleteAsync();

            return model;
        }

        public async Task<IList<OutdoorModel>> GetAllOutdoors()
        {
            var outdoors = await _unitOfWork.Outdoors.GetAll();
            var outdoorsModel = outdoors.Select(o => new OutdoorModel(o)).ToList();

            return outdoorsModel;
        }

        //Lake
        public async Task<IList<LakeModel>> GetAllLakes()
        {
            var lakes = await _unitOfWork.Lakes.GetAll();
            var lakesModel = lakes.Select(l => new LakeModel(l)).ToList();

            return lakesModel;
        }

        public async Task<CreateLakesModel> CreateLakes(CreateLakesModel model)
        {
            var lakes = model.ToLake();
            await _unitOfWork.Lakes.Add(lakes);
            await _unitOfWork.CompleteAsync();

            return model;
        }

        //Park
        public async Task<IList<ParkModel>> GetAllPark()
        {
            var parks = await _unitOfWork.Parks.GetAll();
            var parksModel = parks.Select(p => new ParkModel(p)).ToList();

            return parksModel;
        }

        //Fountain
        public async Task<IList<FountainModel>> GetAllFountain()
        {
            var fountains = await _unitOfWork.Fountains.GetAll();
            var fountainModel = fountains.Select(f=>new FountainModel(f)).ToList();

            return fountainModel;
        }

        //Landmark
        public async Task<IList<LandmarkModel>> GetAllLandmarks()
        {
            var landmarks = await _unitOfWork.Landmarks.GetAll();
            var landmarkModel = landmarks.Select(l => new LandmarkModel(l)).ToList();

            return landmarkModel;
        }

        //NatureReserve
        public async Task<IList<NatureReserveModel>> GetAllNatureReserves()
        {
            var natureReserves = await _unitOfWork.NatureReserves.GetAll();
            var natureReserveModel = natureReserves.Select(n=> new NatureReserveModel(n)).ToList();

            return natureReserveModel;
        }

        //Villa
        public async Task<IList<VillaModel>> GetAllVilla()
        {
            var villas = await _unitOfWork.Villas.GetAll();
            var villaModel = villas.Select(v => new VillaModel(v)).ToList();

            return villaModel;
        }
    }
}
