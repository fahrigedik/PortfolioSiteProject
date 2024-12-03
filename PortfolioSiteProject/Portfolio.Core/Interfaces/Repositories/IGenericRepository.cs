
namespace Portfolio.Core.Interfaces.Repositories;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdAsync(Guid id);
    Task<List<T>> GetAllAsync();
    Task AddAsync(T entitiy);
    Task UpdateAsync(T entity);
    Task DeleteAsync(Guid id);
}

