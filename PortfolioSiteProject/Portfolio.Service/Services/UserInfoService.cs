using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Service.Services;
public class UserInfoService(IUserInfoRepository userInfoRepository, IMapper mapper) : IUserInfoService
{
    public async Task<List<UserInfoDto>> GetAllListAsync()
    {
        var userInfos = await userInfoRepository.GetAllAsync();
        var userInfoDtos = mapper.Map<List<UserInfoDto>>(userInfos);
        return userInfoDtos;
    }
}
