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
    }
}
