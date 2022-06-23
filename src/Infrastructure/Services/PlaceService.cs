using Core.Entities;
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
        public async Task<CreateOutdoorsModel> CreateOutdoor(CreateOutdoorsModel model)
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
        public async Task<CreateParksModel> CreatePark(CreateParksModel model)
        {
            var parks = model.ToPark();
            await _unitOfWork.Parks.Add(parks);
            await _unitOfWork.CompleteAsync();

            return model;
        }

        //Fountain
        public async Task<IList<FountainModel>> GetAllFountain()
        {
            var fountains = await _unitOfWork.Fountains.GetAll();
            var fountainModel = fountains.Select(f => new FountainModel(f)).ToList();

            return fountainModel;
        }

        public async Task<CreateFountainsModel> CreateFountain(CreateFountainsModel model)
        {
            var fountains = model.ToFountain();
            await _unitOfWork.Fountains.Add(fountains);
            await _unitOfWork.CompleteAsync();

            return model;
        }

        //Landmark
        public async Task<IList<LandmarkModel>> GetAllLandmarks()
        {
            var landmarks = await _unitOfWork.Landmarks.GetAll();
            var landmarkModel = landmarks.Select(l => new LandmarkModel(l)).ToList();

            return landmarkModel;
        }

        public async Task<CreateLandmarksModel> CreateLandmark(CreateLandmarksModel model)
        {
            var landmarks = model.ToLandmark();
            await _unitOfWork.Landmarks.Add(landmarks);
            await _unitOfWork.CompleteAsync();

            return model;
        }

        //NatureReserve
        public async Task<IList<NatureReserveModel>> GetAllNatureReserves()
        {
            var natureReserves = await _unitOfWork.NatureReserves.GetAll();
            var natureReserveModel = natureReserves.Select(n => new NatureReserveModel(n)).ToList();

            return natureReserveModel;
        }

        public async Task<CreateNatureReservesModel> CreateNatureReserve(CreateNatureReservesModel model)
        {
            var natureReserves = model.ToNatureReserve();
            await _unitOfWork.NatureReserves.Add(natureReserves);
            await _unitOfWork.CompleteAsync();

            return model;
        }

        //Villa
        public async Task<IList<VillaModel>> GetAllVilla()
        {
            var villas = await _unitOfWork.Villas.GetAll();
            var villaModel = villas.Select(v => new VillaModel(v)).ToList();

            return villaModel;
        }

        public async Task<CreateVillasModel> CreateVilla(CreateVillasModel model)
        {
            var villas = model.ToVilla();
            await _unitOfWork.Villas.Add(villas);
            await _unitOfWork.CompleteAsync();

            return model;
        }


        public async Task Delete(int parkId)
        {
            var park = await _unitOfWork.Parks.GetParkById(parkId);
            if (park != null)
            {
                _unitOfWork.Parks.Delete(park);
                await _unitOfWork.CompleteAsync();
            }
            
        }
    }
}
