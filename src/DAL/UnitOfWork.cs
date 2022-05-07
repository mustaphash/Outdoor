using DAL.Repositories.Abstract;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OutdoorContext _context;

        private readonly IAnimalRepository _animalRepository;

        private readonly IExtrasRepository _extrasRepository;

        public UnitOfWork(
            OutdoorContext context,
            IAnimalRepository animalRepository,
            IExtrasRepository extrasRepository)
        {
            _context = context;
            _animalRepository = animalRepository;
            _extrasRepository = extrasRepository;
        }

        public IAnimalRepository Animals => _animalRepository;

        public IExtrasRepository Extras => _extrasRepository;

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
