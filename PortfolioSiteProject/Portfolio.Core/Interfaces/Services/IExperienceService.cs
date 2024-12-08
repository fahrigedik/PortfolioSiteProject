using Portfolio.Core.DTOs;
using Portfolio.Entity.Entities;

namespace Portfolio.Core.Interfaces.Services;

public interface IExperienceService
{
    Task<List<ExperienceDto>> GetAllVisibleAsync();
    Task<List<Experience>> GetAllAsync();
    Task<Experience> GetByIdAsync(Guid id);
    Task UpdateAsync(Experience requestModel);
    Task DeleteAsync(Guid id);
    Task CreateAsync(Experience requestModel);
}