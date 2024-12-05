using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Service.Services;
public class ExperienceService(IExperienceRepository experienceRepository, IMapper mapper) : IExperienceService
{
    public async Task<List<ExperienceDto>> GetAllListAsync()
    {
        var experiences = await experienceRepository.GetAllAsync();
        var experienceDto = mapper.Map<List<ExperienceDto>>(experiences);
        return experienceDto;
    }
}
