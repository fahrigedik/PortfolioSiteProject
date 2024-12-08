using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Interfaces.UnitOfWork;
using Portfolio.Entity.Entities;
using Portfolio.Repository.Repositories;
using Portfolio.Repository.UnitOfWorks;

namespace Portfolio.Service.Services;

public class HeroSectionService(IHeroSectionRepository heroSectionRepository, IUnitOfWork unitOfWork , IMapper mapper) : IHeroSectionService
{
    public async Task<List<HeroSectionDto>> GetAllVisibleAsync()
    {
        var heroSections = await heroSectionRepository.GetAllVisibleAsync();
        var heroSectionDtos = mapper.Map<List<HeroSectionDto>>(heroSections);
        return heroSectionDtos;
    }

    public async Task<List<HeroSection>> GetAllAsync()
    {
        var heroSections = await heroSectionRepository.GetAllAsync();
        return heroSections;
    }

    public async Task<HeroSection> GetByIdAsync(Guid id)
    {
        var heroSection = await heroSectionRepository.GetByIdAsync(id);
        return heroSection;
    }

    public async Task UpdateAsync(HeroSection requestModel)
    {
        heroSectionRepository.Update(requestModel); 
        unitOfWork.SaveChanges();
    }

    public async Task DeleteAsync(Guid id)
    {
        var heroSection = await heroSectionRepository.GetByIdAsync(id);
        heroSectionRepository.Delete(heroSection);
        unitOfWork.SaveChanges();
    }
}

