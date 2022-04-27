namespace DAL.Repositories.Abstract
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
