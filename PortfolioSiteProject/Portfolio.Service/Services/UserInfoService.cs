using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Interfaces.UnitOfWork;
using Portfolio.Entity.Entities;
using Portfolio.Repository.Repositories;
using Portfolio.Repository.UnitOfWorks;

namespace Portfolio.Service.Services;
public class UserInfoService(IUserInfoRepository userInfoRepository, IUnitOfWork unitOfWork, IMapper mapper) : IUserInfoService
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

    public async Task<UserInfo> GetByIdAsync(Guid id)
    {
        var userInfo = await userInfoRepository.GetByIdAsync(id);
        return userInfo;
    }

    public async Task UpdateAsync(UserInfo requestModel)
    {
        userInfoRepository.Update(requestModel);
        unitOfWork.SaveChanges();
    }

    public async Task DeleteAsync(Guid id)
    {
        var userInfo = await userInfoRepository.GetByIdAsync(id);
        userInfoRepository.Delete(userInfo);
        unitOfWork.SaveChanges();
    }

    public async Task CreateAsync(UserInfo requestModel)
    {
        await userInfoRepository.AddAsync(requestModel);
        unitOfWork.SaveChanges();
    }
}
