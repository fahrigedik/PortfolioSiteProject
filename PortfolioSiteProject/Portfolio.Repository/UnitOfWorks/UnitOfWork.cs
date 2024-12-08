using Portfolio.Core.Interfaces.UnitOfWork;

namespace Portfolio.Repository.UnitOfWorks;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public async Task<int> SaveChangesAsync()
    {
        return await context.SaveChangesAsync();
    }

    public void SaveChanges()
    {
        context.SaveChanges();
    }
}

