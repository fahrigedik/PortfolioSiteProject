using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Interfaces.UnitOfWork;
using Portfolio.Entity.Entities;
namespace Portfolio.Service.Services;
public class SkillService(ISkillRepository skillRepository, IUnitOfWork unitOfWork ,IMapper mapper) : ISkillService
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

    public async Task<Skill> GetByIdAsync(Guid id)
    {
        var skill = await skillRepository.GetByIdAsync(id);
        return skill;
    }

    public async Task UpdateAsync(Skill requestModel)
    {
        skillRepository.Update(requestModel);
        unitOfWork.SaveChanges();
    }

    public async Task DeleteAsync(Guid id)
    {
        var skill = await skillRepository.GetByIdAsync(id);
        skillRepository.Delete(skill);
        unitOfWork.SaveChanges();
    }

    public async Task CreateAsync(Skill requestModel)
    {
        await skillRepository.AddAsync(requestModel);
        unitOfWork.SaveChanges();
    }
}

