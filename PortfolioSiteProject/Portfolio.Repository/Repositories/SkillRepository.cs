
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Entity.Entities;

namespace Portfolio.Repository.Repositories;

public class SkillRepository(AppDbContext context) : GenericRepository<Skill>(context), ISkillRepository
{

}

