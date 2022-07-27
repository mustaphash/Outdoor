using Common;
using Common.LoggerRecources;
using DAL;
using Infrastructure.Models;
using Infrastructure.Services.Abstract;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Services
{
    public class NomenclatureService : INomenclatureService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public NomenclatureService(IUnitOfWork unitOfWork, ILogger<NomenclatureService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<IList<AnimalModel>> GetAllAnimals()
        {
            _logger.LogInformation(LogMessages.GettingItem, string.Format(LogMessageResources.GettingItem, nameof(NomenclatureService), nameof(GetAllAnimals)));

            var animals = await _unitOfWork.Animals.GetAll();
            var animalsModel = animals.Select(a => new AnimalModel(a)).ToList();

            _logger.LogInformation(LogMessages.GotItem, string.Format(LogMessageResources.GotItem, nameof(NomenclatureService), nameof(GetAllAnimals)));
            return animalsModel;
        }

        public async Task<IList<ExtrasModel>> GetAllExtras()
        {
            _logger.LogInformation(LogMessages.GettingItem, string.Format(LogMessageResources.GettingItem, nameof(NomenclatureService), nameof(GetAllExtras)));

            var extras = await _unitOfWork.Extras.GetAll();
            var extrasModel = extras.Select(e => new ExtrasModel(e)).ToList();

            _logger.LogInformation(LogMessages.GotItem, string.Format(LogMessageResources.GotItem, nameof(NomenclatureService), nameof(GetAllExtras)));
            return extrasModel;
        }

        public async Task<IList<WaterTypeModel>> GetAllWaterTypes()
        {
            _logger.LogInformation(LogMessages.GettingItem, string.Format(LogMessageResources.GettingItem, nameof(NomenclatureService), nameof(GetAllWaterTypes)));

            var waterTypes = await _unitOfWork.WaterTypes.GetAll();
            var waterTypesModel = waterTypes.Select(e => new WaterTypeModel(e)).ToList();

            _logger.LogInformation(LogMessages.GotItem, string.Format(LogMessageResources.GotItem, nameof(NomenclatureService), nameof(GetAllWaterTypes)));
            return waterTypesModel;
        }
    }
}
