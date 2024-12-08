using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Entity.Entities;

namespace Portfolio.Service.Services;
public class UserInfoService(IUserInfoRepository userInfoRepository, IMapper mapper) : IUserInfoService
{
    public async Task<List<UserInfoDto>> GetAllVisibleAsync()
    {
        var userInfos = await userInfoRepository.GetAllVisibleAsync();
        var userInfoDtos = mapper.Map<List<UserInfoDto>>(userInfos);
        return userInfoDtos;
    }

    public async Task<List<UserInfo>> GetAllAsync()
    {
        var userInfos = await userInfoRepository.GetAllAsync();
        return userInfos;
    }
}
