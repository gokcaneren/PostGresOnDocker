using Microsoft.EntityFrameworkCore;

namespace SimpleApi.Dal.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbbbContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(DbbbContext context)
        {
            _context = context;
            _dbSet=_context.Set<T>();
        }

        public async void AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<T> GetAllAsync()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async void Remove(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async void Update(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}