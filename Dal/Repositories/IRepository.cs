namespace SimpleApi.Dal.Repositories
{
    public interface IRepository<T> where T : class
    {
        void AddAsync(T entity);
        IQueryable<T> GetAllAsync();
        Task<T> GetAsync(int id);
        void Update(T entity);
        void Remove(T entity);
    }
}