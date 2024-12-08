using Portfolio.Core.DTOs;
using Portfolio.Entity.Entities;

namespace Portfolio.Core.Interfaces.Services;
public interface ISocialLinkService
{
    Task<List<SocialLinkDto>> GetAllVisibleAsync();
    Task<List<SocialLink>> GetAllAsync();
    Task<SocialLink> GetByIdAsync(Guid id);
    Task UpdateAsync(SocialLink requestModel);
    Task DeleteAsync(Guid id);
    Task CreateAsync(SocialLink requestModel);
}

