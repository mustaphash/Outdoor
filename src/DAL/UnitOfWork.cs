using DAL.Repositories.Abstract;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OutdoorContext _context;

        private readonly IAnimalRepository _animalRepository;

        private readonly IExtrasRepository _extrasRepository;

        private readonly IWaterTypeRepository _waterTypeRepository;

        private readonly IOutdoorRepository _outdoorRepository;

        private readonly ILakeRepositry _lakeRepository;

        private readonly IFountainRepository _fountainRepository;

        private readonly ILandmarkRepository _landmarkRepository;

        private readonly INatureReserveRepository _natureReserveRepository;

        private readonly IParkRepository _parkRepository;

        private readonly IVillaRepository _villaRepository;

        public UnitOfWork(
            OutdoorContext context,
            IAnimalRepository animalRepository,
            IExtrasRepository extrasRepository,
            IWaterTypeRepository waterTypeRepository,
            IOutdoorRepository outdoorRepository,
            ILakeRepositry lakeRepository,
            IFountainRepository fountainRepository,
            ILandmarkRepository landmarkRepository,
            INatureReserveRepository natureReserveRepository,
            IParkRepository parkRepository,
            IVillaRepository villaRepository)
        {
            _context = context;
            _animalRepository = animalRepository;
            _extrasRepository = extrasRepository;
            _waterTypeRepository = waterTypeRepository;
            _outdoorRepository = outdoorRepository;
            _lakeRepository = lakeRepository;
            _fountainRepository = fountainRepository;
            _landmarkRepository = landmarkRepository;
            _natureReserveRepository = natureReserveRepository;
            _parkRepository = parkRepository;
            _villaRepository = villaRepository;
        }

        public IAnimalRepository Animals => _animalRepository;

        public IExtrasRepository Extras => _extrasRepository;

        public IWaterTypeRepository WaterTypes => _waterTypeRepository;

        public IOutdoorRepository Outdoors => _outdoorRepository;

        public ILakeRepositry Lakes => _lakeRepository;

        public IFountainRepository Fountains => _fountainRepository;

        public ILandmarkRepository Landmarks => _landmarkRepository;

        public INatureReserveRepository NatureReserves => _natureReserveRepository;

        public IParkRepository Parks => _parkRepository;

        public IVillaRepository Villas => _villaRepository;

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
