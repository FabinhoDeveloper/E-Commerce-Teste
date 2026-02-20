namespace e_commerce_api.Source.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAsync();
        Task<T> AddAsync(T entity);
        Task Update(int id, T entity);
        Task Delete(T entity);
    }
}