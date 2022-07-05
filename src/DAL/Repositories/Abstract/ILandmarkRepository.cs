using Core.Entities;

namespace DAL.Repositories.Abstract
{
    public interface ILandmarkRepository : IBaseRepository<Landmark>
    {
        Task<Landmark> GetLandmarkById(int id);

        Task<List<Landmark>> GetAllLandmarks();
    }
}
