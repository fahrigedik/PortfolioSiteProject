
using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Interfaces.Repositories;

namespace Portfolio.Repository.Generic;

public class GenericRepository<T>(AppDbContext context) : IGenericRepository<T> where T : class
{
    protected AppDbContext Context = context;

    private DbSet<T> _dbSet = context.Set<T>();

    public async Task<T> GetByIdAsync(Guid id)
    {
        var entity = await _dbSet.FindAsync(id);
        return entity;
    }

    public async Task<List<T>> GetAllAsync()
    {
        var entities = await _dbSet.ToListAsync();
        return entities;
    }

    public async Task AddAsync(T entitiy)
    {
        var result = await _dbSet.AddAsync(entitiy);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }
}

