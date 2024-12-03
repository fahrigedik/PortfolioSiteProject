
namespace Portfolio.Core.Interfaces.Repositories;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdAsync(Guid id);
    Task<List<T>> GetAllAsync();
    Task AddAsync(T entitiy);
    void Update(T entity);
    void Delete(T entity);
}

