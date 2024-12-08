using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Entity.Entities;

namespace Portfolio.Service.Services;
public class SocialLinkService(ISocialLinkRepository socialLinkRepository, IMapper mapper) : ISocialLinkService
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
}

