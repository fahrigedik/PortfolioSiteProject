using Portfolio.Core.DTOs;
using Portfolio.Entity.Entities;

namespace Portfolio.Core.Interfaces.Services;

public interface ISkillService
{
    Task<List<SkillDto>> GetAllVisibleAsync();

    Task<List<Skill>> GetAllAsync();
    Task<Skill> GetByIdAsync(Guid id);
    Task UpdateAsync(Skill requestModel);
    Task DeleteAsync(Guid id);
    Task CreateAsync(Skill requestModel);
}

