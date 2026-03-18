using System.Linq.Expressions;

namespace VideogameArchiveAPI.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, bool tracked = true);
        public Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true);
        public Task DeleteAsync(T entity);
        public Task CreateAsync(T entity);
        public Task SaveChangesAsync();
    }
}
