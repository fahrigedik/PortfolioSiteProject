using Portfolio.Core.DTOs;
using Portfolio.Entity.Entities;

namespace Portfolio.Core.Interfaces.Services;

public interface IUserInfoService
{
    Task<List<UserInfoDto>> GetAllVisibleAsync();
    Task<List<UserInfo>> GetAllAsync();
    Task<UserInfo> GetByIdAsync(Guid id);
    Task UpdateAsync(UserInfo requestModel);
    Task DeleteAsync(Guid id);
    Task CreateAsync(UserInfo requestModel);
}

