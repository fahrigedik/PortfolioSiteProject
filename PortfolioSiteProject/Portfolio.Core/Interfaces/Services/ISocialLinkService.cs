using Portfolio.Core.DTOs;

namespace Portfolio.Core.Interfaces.Services;
public interface ISocialLinkService
{
    Task<List<SocialLinkDto>> GetAllListAsync();
}

