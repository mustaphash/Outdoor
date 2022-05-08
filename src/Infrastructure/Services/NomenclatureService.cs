using DAL;
using Infrastructure.Models;
using Infrastructure.Services.Abstract;

namespace Infrastructure.Services
{
    public class NomenclatureService : INomenclatureService
    {
        private readonly IUnitOfWork _unitOfWork;

        public NomenclatureService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IList<AnimalModel>> GetAllAnimals()
        {
            var animals = await _unitOfWork.Animals.GetAll();
            var animalsModel = animals.Select(a => new AnimalModel(a)).ToList();

            return animalsModel;
        }

        public async Task<IList<ExtrasModel>> GetAllExtras()
        {
            var extras = await _unitOfWork.Extras.GetAll();
            var extrasModel = extras.Select(e => new ExtrasModel(e)).ToList();

            return extrasModel;
        }

        public async Task<IList<WaterTypeModel>> GetAllWaterTypes()
        {
            var waterTypes = await _unitOfWork.WaterTypes.GetAll();
            var waterTypesModel = waterTypes.Select(e => new WaterTypeModel(e)).ToList();

            return waterTypesModel;
        }
    }
}
