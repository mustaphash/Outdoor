using Core.Entities;

namespace DAL.Repositories.Abstract
{
    public interface ILakeRepositry : IBaseRepository<Lake>
    {
        Task<Lake> GetLakeById(int id);

        Task<List<Lake>> GetAllLakes();
    }
}
