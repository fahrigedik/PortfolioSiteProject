using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Entity.Entities;

namespace Portfolio.Service.Services;
public class ExperienceService(IExperienceRepository experienceRepository, IMapper mapper) : IExperienceService
{
    public async Task<List<ExperienceDto>> GetAllVisibleAsync()
    {
        var experiences = await experienceRepository.GetAllVisibleAsync();
        var experienceDto = mapper.Map<List<ExperienceDto>>(experiences);
        return experienceDto;
    }

    public async Task<List<Experience>> GetAllAsync()
    {
        var experiences = await experienceRepository.GetAllAsync();
        return experiences;
    }
}
