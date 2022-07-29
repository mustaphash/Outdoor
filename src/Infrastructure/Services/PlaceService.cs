using Common;
using Common.LoggerRecources;
using Core.Entities;
using Core.Validation;
using DAL;
using Infrastructure.Models;
using Infrastructure.Models.CreateModels;
using Infrastructure.Services.Abstract;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Services
{
    public class PlaceService : IPlaceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;
        private readonly IValidation<CreateFountainsModel> _fountainsValidator;
        private readonly IValidation<CreateLakesModel> _lakesValidator;
        public PlaceService(
            IUnitOfWork unitOfWork, 
            ILogger<PlaceService> logger, 
            IValidation<CreateFountainsModel> fountainsValidator,
            IValidation<CreateLakesModel> lakesValidator)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _fountainsValidator = fountainsValidator;
            _lakesValidator = lakesValidator;
        }

        //Outdoor
        public async Task<CreateOutdoorsModel> CreateOutdoor(CreateOutdoorsModel model)
        {
            _logger.LogInformation(LogMessages.InsertingItem, string.Format(LogMessageResources.InsertingItem, nameof(PlaceService), nameof(CreateOutdoor)));

            var outdoors = model.ToOutdoor();
            await _unitOfWork.Outdoors.Add(outdoors);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation(LogMessages.InsertedItem, string.Format(LogMessageResources.InsertedItem, nameof(PlaceService), nameof(CreateOutdoor)));
            return model;
        }

        public async Task<IList<OutdoorModel>> GetAllOutdoors()
        {
            _logger.LogInformation(LogMessages.GettingItem, string.Format(LogMessageResources.GettingItem, nameof(PlaceService), nameof(GetAllOutdoors)));

            var outdoors = await _unitOfWork.Outdoors.GetAll();
            var outdoorsModel = outdoors.Select(o => new OutdoorModel(o)).ToList();

            _logger.LogInformation(LogMessages.GotItem, string.Format(LogMessageResources.GotItem, nameof(PlaceService), nameof(GetAllOutdoors)));
            return outdoorsModel;
        }

        public async Task DeleteOutdoor(int outId)
        {
            _logger.LogInformation(LogMessages.DeletingItem, string.Format(LogMessageResources.DeletingItem, nameof(outId), nameof(PlaceService), nameof(DeleteOutdoor)));

            var outdoor = await _unitOfWork.Outdoors.GetOutdoorById(outId);
            if (outdoor != null)
            {
                _unitOfWork.Outdoors.Delete(outdoor);
                await _unitOfWork.CompleteAsync();
            }
            _logger.LogInformation(LogMessages.DeletedItem, string.Format(LogMessageResources.DeletedItem, nameof(outId), nameof(PlaceService), nameof(DeleteOutdoor)));
        }

        //Lake
        public async Task<IList<LakeModel>> GetAllLakes()
        {
            _logger.LogInformation(LogMessages.GettingItem, string.Format(LogMessageResources.GettingItem, nameof(PlaceService), nameof(GetAllLakes)));
            var lakes = await _unitOfWork.Lakes.GetAllLakes();
            var lakesModel = lakes.Select(l => new LakeModel(l)).ToList();

            _logger.LogInformation(LogMessages.GotItem, string.Format(LogMessageResources.GotItem, nameof(PlaceService), nameof(GetAllLakes)));
            return lakesModel;
        }

        public async Task<CreateLakesModel> CreateLakes(CreateLakesModel model)
        {
            //TODO: validation!
            await _validationLakes.Validate(model);
            _logger.LogInformation(LogMessages.InsertingItem, string.Format(LogMessageResources.InsertingItem, nameof(PlaceService), nameof(CreateLakes)));

            var animals = await _unitOfWork.Animals.GetAnimalsByIds(model.Animals);
            var extras = await _unitOfWork.Extras.GetExtrasByIds(model.Extras);
            var lakes = model.ToLake();
            lakes.Animals = new List<Animal>();
            lakes.Extras = new List<Extras>();
            foreach (var animal in animals)
            {
                lakes.Animals.Add(animal);
            }
            foreach (var extra in extras)
            {
                lakes.Extras.Add(extra);
            }
            await _unitOfWork.Lakes.Add(lakes);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation(LogMessages.InsertedItem, string.Format(LogMessageResources.InsertedItem, nameof(PlaceService), nameof(CreateLakes)));
            return model;
        }

        public async Task DeleteLake(int lakeId)
        {
            _logger.LogInformation(LogMessages.DeletingItem, string.Format(LogMessageResources.DeletingItem, nameof(lakeId), nameof(PlaceService), nameof(DeleteLake)));

            var lake = await _unitOfWork.Lakes.GetLakeById(lakeId);
            if (lake != null)
            {
                _unitOfWork.Lakes.Delete(lake);
                await _unitOfWork.CompleteAsync();
            }
            _logger.LogInformation(LogMessages.DeletedItem, string.Format(LogMessageResources.DeletedItem, nameof(lakeId), nameof(PlaceService), nameof(DeleteLake)));
        }

        //Park
        public async Task<IList<ParkModel>> GetAllPark()
        {
            _logger.LogInformation(LogMessages.GettingItem, string.Format(LogMessageResources.GettingItem, nameof(PlaceService), nameof(GetAllPark)));
            var parks = await _unitOfWork.Parks.GetAllParks();
            var parksModel = parks.Select(p => new ParkModel(p)).ToList();

            _logger.LogInformation(LogMessages.GotItem, string.Format(LogMessageResources.GotItem, nameof(PlaceService), nameof(GetAllPark)));
            return parksModel;
        }
        public async Task<CreateParksModel> CreatePark(CreateParksModel model)
        {
            _logger.LogInformation(LogMessages.InsertingItem, string.Format(LogMessageResources.InsertingItem, nameof(PlaceService), nameof(CreatePark)));
            var animals = await _unitOfWork.Animals.GetAnimalsByIds(model.Animals);
            var extras = await _unitOfWork.Extras.GetExtrasByIds(model.Extras);
            var parks = model.ToPark();
            parks.Animals = new List<Animal>();
            parks.Extras = new List<Extras>();
            foreach (var animal in animals)
            {
                parks.Animals.Add(animal);
            }
            foreach (var extra in extras)
            {
                parks.Extras.Add(extra);
            }
            await _unitOfWork.Parks.Add(parks);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation(LogMessages.InsertedItem, string.Format(LogMessageResources.InsertedItem, nameof(PlaceService), nameof(CreatePark)));
            return model;
        }

        public async Task DeletePark(int parkId)
        {
            _logger.LogInformation(LogMessages.DeletingItem, string.Format(LogMessageResources.DeletingItem, nameof(parkId), nameof(PlaceService), nameof(DeletePark)));

            var park = await _unitOfWork.Parks.GetParkById(parkId);
            if (park != null)
            {
                _unitOfWork.Parks.Delete(park);
                await _unitOfWork.CompleteAsync();
            }
            _logger.LogInformation(LogMessages.DeletedItem, string.Format(LogMessageResources.DeletedItem, nameof(parkId), nameof(PlaceService), nameof(DeletePark)));

        }

        //Fountain
        public async Task<IList<FountainModel>> GetAllFountain()
        {
            _logger.LogInformation(LogMessages.GettingItem, string.Format(LogMessageResources.GettingItem, nameof(PlaceService), nameof(GetAllFountain)));

            var fountains = await _unitOfWork.Fountains.GetAllFountains();
            var fountainModel = fountains.Select(f => new FountainModel(f)).ToList();

            _logger.LogInformation(LogMessages.GotItem, string.Format(LogMessageResources.GotItem, nameof(PlaceService), nameof(GetAllFountain)));
            return fountainModel;
        }

        public async Task<CreateFountainsModel> CreateFountain(CreateFountainsModel model)
        {
            await _validationFountains.Validate(model);
            _logger.LogInformation(LogMessages.InsertingItem, string.Format(LogMessageResources.InsertingItem, nameof(PlaceService), nameof(CreateFountain)));

            var fountains = model.ToFountain();
            var extras = await _unitOfWork.Extras.GetExtrasByIds(model.Extras);
            fountains.Extras = new List<Extras>();
            foreach (var extra in extras)
            {
                fountains.Extras.Add(extra);
            }
            await _unitOfWork.Fountains.Add(fountains);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation(LogMessages.InsertedItem, string.Format(LogMessageResources.InsertedItem, nameof(PlaceService), nameof(CreateFountain)));
            return model;
        }

        public async Task DeleteFountain(int fountainId)
        {
            _logger.LogInformation(LogMessages.DeletingItem, string.Format(LogMessageResources.DeletingItem, nameof(fountainId), nameof(PlaceService), nameof(DeleteFountain)));

            var fountain = await _unitOfWork.Fountains.GetFountainById(fountainId);
            if (fountain != null)
            {
                _unitOfWork.Fountains.Delete(fountain);
                await _unitOfWork.CompleteAsync();
            }
            _logger.LogInformation(LogMessages.DeletingItem, string.Format(LogMessageResources.DeletedItem, nameof(fountainId), nameof(PlaceService), nameof(DeleteFountain)));
        }

        //Landmark
        public async Task<IList<LandmarkModel>> GetAllLandmarks()
        {
            _logger.LogInformation(LogMessages.GettingItem, string.Format(LogMessageResources.GettingItem, nameof(PlaceService), nameof(GetAllLandmarks)));

            var landmarks = await _unitOfWork.Landmarks.GetAllLandmarks();
            var landmarkModel = landmarks.Select(l => new LandmarkModel(l)).ToList();

            _logger.LogInformation(LogMessages.GotItem, string.Format(LogMessageResources.GotItem, nameof(PlaceService), nameof(GetAllLandmarks)));
            return landmarkModel;
        }

        public async Task<CreateLandmarksModel> CreateLandmark(CreateLandmarksModel model)
        {
            _logger.LogInformation(LogMessages.InsertingItem, string.Format(LogMessageResources.InsertingItem, nameof(PlaceService), nameof(CreateLandmark)));

            var extras = await _unitOfWork.Extras.GetExtrasByIds(model.Extras);
            var landmarks = model.ToLandmark();
            landmarks.Extras = new List<Extras>();
            foreach (var extra in extras)
            {
                landmarks.Extras.Add(extra);
            }
            await _unitOfWork.Landmarks.Add(landmarks);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation(LogMessages.InsertedItem, string.Format(LogMessageResources.InsertedItem, nameof(PlaceService), nameof(CreateLandmark)));
            return model;
        }

        public async Task DeleteLandmark(int landmarkId)
        {
            _logger.LogInformation(LogMessages.DeletingItem, string.Format(LogMessageResources.DeletingItem, nameof(landmarkId), nameof(PlaceService), nameof(DeleteLandmark)));

            var landmark = await _unitOfWork.Landmarks.GetLandmarkById(landmarkId);
            if (landmark != null)
            {
                _unitOfWork.Landmarks.Delete(landmark);
                await _unitOfWork.CompleteAsync();
            }
            _logger.LogInformation(LogMessages.DeletedItem, string.Format(LogMessageResources.DeletedItem, nameof(landmarkId), nameof(PlaceService), nameof(DeleteLandmark)));
        }

        //NatureReserve
        public async Task<IList<NatureReserveModel>> GetAllNatureReserves()
        {
            _logger.LogInformation(LogMessages.GettingItem, string.Format(LogMessageResources.GettingItem, nameof(PlaceService), nameof(GetAllNatureReserves)));

            var natureReserves = await _unitOfWork.NatureReserves.GetAllReserves();
            var natureReserveModel = natureReserves.Select(n => new NatureReserveModel(n)).ToList();

            _logger.LogInformation(LogMessages.GotItem, string.Format(LogMessageResources.GotItem, nameof(PlaceService), nameof(GetAllNatureReserves)));
            return natureReserveModel;
        }

        public async Task<CreateNatureReservesModel> CreateNatureReserve(CreateNatureReservesModel model)
        {
            _logger.LogInformation(LogMessages.InsertingItem, string.Format(LogMessageResources.InsertingItem, nameof(PlaceService), nameof(CreateNatureReserve)));

            var animals = await _unitOfWork.Animals.GetAnimalsByIds(model.Animals);
            var extras = await _unitOfWork.Extras.GetExtrasByIds(model.Extras);
            var natureReserves = model.ToNatureReserve();
            natureReserves.Animal = new List<Animal>();
            natureReserves.Extras = new List<Extras>();
            foreach (var animal in animals)
            {
                natureReserves.Animal.Add(animal);
            }
            foreach (var extra in extras)
            {
                natureReserves.Extras.Add(extra);
            }
            await _unitOfWork.NatureReserves.Add(natureReserves);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation(LogMessages.InsertedItem, string.Format(LogMessageResources.InsertedItem, nameof(PlaceService), nameof(CreateNatureReserve)));
            return model;
        }

        public async Task DeleteNatureReserve(int reserveId)
        {
            _logger.LogInformation(LogMessages.DeletingItem, string.Format(LogMessageResources.DeletingItem, nameof(reserveId), nameof(PlaceService), nameof(DeleteNatureReserve)));

            var reserve = await _unitOfWork.NatureReserves.GetReserveById(reserveId);
            if (reserve != null)
            {
                _unitOfWork.NatureReserves.Delete(reserve);
                await _unitOfWork.CompleteAsync();
            }
            _logger.LogInformation(LogMessages.DeletedItem, string.Format(LogMessageResources.DeletedItem, nameof(reserveId), nameof(PlaceService), nameof(DeleteNatureReserve)));
        }

        //Villa
        public async Task<IList<VillaModel>> GetAllVilla()
        {
            _logger.LogInformation(LogMessages.GettingItem, string.Format(LogMessageResources.GettingItem, nameof(PlaceService), nameof(GetAllVilla)));
            var villas = await _unitOfWork.Villas.GetAll();
            var villaModel = villas.Select(v => new VillaModel(v)).ToList();

            _logger.LogInformation(LogMessages.GotItem, string.Format(LogMessageResources.GotItem, nameof(PlaceService), nameof(GetAllVilla)));
            return villaModel;
        }

        public async Task<CreateVillasModel> CreateVilla(CreateVillasModel model)
        {
            _logger.LogInformation(LogMessages.InsertingItem, string.Format(LogMessageResources.InsertingItem, nameof(PlaceService), nameof(CreateVilla)));

            var extras = await _unitOfWork.Extras.GetExtrasByIds(model.Extras);
            var villas = model.ToVilla();
            villas.Extras = new List<Extras>();
            foreach (var extra in extras)
            {
                villas.Extras.Add(extra);
            }
            await _unitOfWork.Villas.Add(villas);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation(LogMessages.InsertedItem, string.Format(LogMessageResources.InsertedItem, nameof(PlaceService), nameof(CreateVilla)));
            return model;
        }

        public async Task DeleteVilla(int villaId)
        {
            _logger.LogInformation(LogMessages.DeletingItem, string.Format(LogMessageResources.DeletingItem, nameof(villaId), nameof(PlaceService), nameof(DeleteVilla)));

            var villa = await _unitOfWork.Villas.GetVillaById(villaId);
            if (villa != null)
            {
                _unitOfWork.Villas.Delete(villa);
                await _unitOfWork.CompleteAsync();
            }
            _logger.LogInformation(LogMessages.DeletedItem, string.Format(LogMessageResources.DeletedItem, nameof(villaId), nameof(PlaceService), nameof(DeleteVilla)));
        }
    }
}
