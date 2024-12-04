using Portfolio.Core.DTOs;
using Portfolio.Entity.Entities;

namespace Portfolio.Core.Interfaces.Services;

public interface IUserInfoService
{
    Task<List<UserInfoDto>> GetAllListAsync();
}

