namespace Portfolio.Core.Interfaces.UnitOfWork;
public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();

    void SaveChanges();
}

