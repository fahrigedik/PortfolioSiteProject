using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Entity.Entities;

namespace Portfolio.Repository.Repositories;

public class UserInfoRepository(AppDbContext context) : GenericRepository<UserInfo>(context), IUserInfoRepository
{

}





