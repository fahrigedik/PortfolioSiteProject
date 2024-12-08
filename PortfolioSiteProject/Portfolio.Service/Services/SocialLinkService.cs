using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Interfaces.UnitOfWork;
using Portfolio.Entity.Entities;
using Portfolio.Repository.Repositories;
using Portfolio.Repository.UnitOfWorks;

namespace Portfolio.Service.Services;
public class SocialLinkService(ISocialLinkRepository socialLinkRepository, IUnitOfWork unitOfWork ,IMapper mapper) : ISocialLinkService
{
    public async Task<List<SocialLinkDto>> GetAllVisibleAsync()
    {
        var socialLinks = await socialLinkRepository.GetAllVisibleAsync();
        var socialLinkDtos = mapper.Map<List<SocialLinkDto>>(socialLinks);
        return socialLinkDtos;
    }

    public async Task<List<SocialLink>> GetAllAsync()
    {
        var socialLinks = await socialLinkRepository.GetAllAsync();
        return socialLinks;
    }

    public async Task<SocialLink> GetByIdAsync(Guid id)
    {
        var socialLink = await socialLinkRepository.GetByIdAsync(id);
        return socialLink;
    }

    public async Task UpdateAsync(SocialLink requestModel)
    {
        socialLinkRepository.Update(requestModel);
        unitOfWork.SaveChanges();
    }

    public async Task DeleteAsync(Guid id)
    {
        var socialLink = await socialLinkRepository.GetByIdAsync(id);
        socialLinkRepository.Delete(socialLink);
        unitOfWork.SaveChanges();
    }

    public async Task CreateAsync(SocialLink requestModel)
    {
        await socialLinkRepository.AddAsync(requestModel);
        unitOfWork.SaveChanges();
    }
}

