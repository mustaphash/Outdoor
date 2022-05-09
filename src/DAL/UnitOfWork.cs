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

        public UnitOfWork(
            OutdoorContext context,
            IAnimalRepository animalRepository,
            IExtrasRepository extrasRepository,
            IWaterTypeRepository waterTypeRepository,
            IOutdoorRepository outdoorRepository)
        {
            _context = context;
            _animalRepository = animalRepository;
            _extrasRepository = extrasRepository;
            _waterTypeRepository = waterTypeRepository;
            _outdoorRepository = outdoorRepository;
        }

        public IAnimalRepository Animals => _animalRepository;

        public IExtrasRepository Extras => _extrasRepository;

        public IWaterTypeRepository WaterTypes => _waterTypeRepository;

        public IOutdoorRepository Outdoors => _outdoorRepository;

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
