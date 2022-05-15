using Core.Entities;
using DAL;
using Infrastructure.Models;
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
            
            return model;
        }

        public async Task<List<OutdoorModel>> GetAllOutdoors()
        {
            var outdoors = await _unitOfWork.Outdoors.GetAll();
            var outdoorsModel = outdoors.Select(o => new OutdoorModel(o)).ToList();

            return outdoorsModel;
        }
    }
}
