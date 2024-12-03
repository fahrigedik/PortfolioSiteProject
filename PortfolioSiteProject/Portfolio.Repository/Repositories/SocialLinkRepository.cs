using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Entity.Entities;

namespace Portfolio.Repository.Repositories;

public class SocialLinkRepository(AppDbContext context) : GenericRepository<SocialLink>(context), ISocialLinkRepository
{

}

