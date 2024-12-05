using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Service.Services;
public class SocialLinkService(ISocialLinkRepository socialLinkRepository, IMapper mapper) : ISocialLinkService
{
    public async Task<List<SocialLinkDto>> GetAllListAsync()
    {
        var socialLinks = await socialLinkRepository.GetAllAsync();
        var socialLinkDtos = mapper.Map<List<SocialLinkDto>>(socialLinks);
        return socialLinkDtos;
    }
}

