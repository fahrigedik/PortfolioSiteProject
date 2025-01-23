
using Portfolio.Core.Base;

namespace Portfolio.Core.Interfaces.Repositories;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(Guid id);
    Task<List<T>> GetAllAsync();
    Task<List<T>> GetAllVisibleAsync();
    Task AddAsync(T entitiy);
    void Update(T entity);
    void Delete(T entity);

    Task<byte[]> GetImageAsync(Guid id);
}

