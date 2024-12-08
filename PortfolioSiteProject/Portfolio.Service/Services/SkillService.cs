using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Entity.Entities;

namespace Portfolio.Service.Services;
public class SkillService(ISkillRepository skillRepository, IMapper mapper) : ISkillService
{
    public async Task<List<SkillDto>> GetAllVisibleAsync()
    {
        var skills = await skillRepository.GetAllVisibleAsync();
        var skillDtos = mapper.Map<List<SkillDto>>(skills);
        return skillDtos;
    }

    public async Task<List<Skill>> GetAllAsync()
    {
        var skills = await skillRepository.GetAllAsync();
        return skills;
    }
}

