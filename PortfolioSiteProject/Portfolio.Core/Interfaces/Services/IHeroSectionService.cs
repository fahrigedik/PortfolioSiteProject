using Portfolio.Core.DTOs;

namespace Portfolio.Core.Interfaces.Services;

public interface IHeroSectionService
{
    Task<List<HeroSectionDto>> GetAllListAsync();
}

