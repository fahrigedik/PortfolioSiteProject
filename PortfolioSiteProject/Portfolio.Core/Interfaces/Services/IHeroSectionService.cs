using Portfolio.Core.DTOs;
using Portfolio.Entity.Entities;

namespace Portfolio.Core.Interfaces.Services;

public interface IHeroSectionService
{
    Task<List<HeroSectionDto>> GetAllVisibleAsync();
    Task<List<HeroSection>> GetAllAsync();
    Task<HeroSection> GetByIdAsync(Guid id);
    Task UpdateAsync(HeroSection requestModel);

}

