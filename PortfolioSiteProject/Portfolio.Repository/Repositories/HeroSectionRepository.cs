using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Entity.Entities;

namespace Portfolio.Repository.Repositories;

public class HeroSectionRepository(AppDbContext context) : GenericRepository<HeroSection>(context), IHeroSectionRepository
{

}

