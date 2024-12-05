using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Service.Services;
public class SkillService(ISkillRepository skillRepository, IMapper mapper) : ISkillService
{
    public async Task<List<SkillDto>> GetAllListAsync()
    {
        var skills = await skillRepository.GetAllAsync();
        var skillDtos = mapper.Map<List<SkillDto>>(skills);
        return skillDtos;
    }
}

