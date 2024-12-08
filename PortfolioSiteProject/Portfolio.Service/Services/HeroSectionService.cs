using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Entity.Entities;
using Portfolio.Repository.Repositories;

namespace Portfolio.Service.Services;

public class HeroSectionService(IHeroSectionRepository heroSectionRepository, IMapper mapper) : IHeroSectionService
{
    public async Task<List<HeroSectionDto>> GetAllVisibleAsync()
    {
        var heroSections = await heroSectionRepository.GetAllVisibleAsync();
        var heroSectionDtos = mapper.Map<List<HeroSectionDto>>(heroSections);
        return heroSectionDtos;
    }

    public async Task<List<HeroSection>> GetAllAsync()
    {
        var experiences = await heroSectionRepository.GetAllAsync();
        return experiences;
    }
}

