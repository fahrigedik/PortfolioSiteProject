using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Entity.Entities;

namespace Portfolio.Repository.Repositories;

public class ExperienceRepository(AppDbContext context) : GenericRepository<Experience>(context), IExperienceRepository
{

}

