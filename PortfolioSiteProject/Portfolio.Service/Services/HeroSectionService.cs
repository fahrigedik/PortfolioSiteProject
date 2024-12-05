using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Service.Services;

public class HeroSectionService(IHeroSectionRepository heroSectionRepository, IMapper mapper) : IHeroSectionService
{
    public async Task<List<HeroSectionDto>> GetAllListAsync()
    {
        var heroSections = await heroSectionRepository.GetAllAsync();
        var heroSectionDtos = mapper.Map<List<HeroSectionDto>>(heroSections);
        return heroSectionDtos;
    }
}

