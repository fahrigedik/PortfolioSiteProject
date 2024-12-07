using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Entity.Entities;

namespace Portfolio.Repository.Repositories;

public class ProjectRepository(AppDbContext context) : GenericRepository<Project>(context), IProjectRepository
{
}

