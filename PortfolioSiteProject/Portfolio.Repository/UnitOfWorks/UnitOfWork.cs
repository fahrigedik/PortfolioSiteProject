using Portfolio.Core.Interfaces.UnitOfWork;

namespace Portfolio.Repository.UnitOfWorks;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public void SaveChanges()
    {
        throw new NotImplementedException();
    }
}

