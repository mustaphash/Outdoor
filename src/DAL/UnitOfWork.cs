using DAL.Repositories.Abstract;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OutdoorContext _context;

        private readonly IAnimalRepository _animalRepository;

        public UnitOfWork(
            OutdoorContext context,
            IAnimalRepository animalRepository)
        {
            _context = context;
            _animalRepository = animalRepository;
        }

        public IAnimalRepository Animals => _animalRepository;

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
