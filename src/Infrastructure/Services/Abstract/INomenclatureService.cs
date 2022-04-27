using Infrastructure.Models;

namespace Infrastructure.Services.Abstract
{
    public interface INomenclatureService
    {
        Task<IList<AnimalModel>> GetAllAnimals();
    }
}
