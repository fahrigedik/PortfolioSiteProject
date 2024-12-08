using Portfolio.Core.DTOs;
using Portfolio.Entity.Entities;

namespace Portfolio.Core.Interfaces.Services;

public interface IProjectService
{
    Task<List<ProjectDto>> GetAllVisibleAsync();
    Task<List<Project>> GetAllAsync();
    Task<Project> GetByIdAsync(Guid id);
    Task UpdateAsync(Project requestModel);
    Task DeleteAsync(Guid id);
    Task CreateAsync(Project requestModel);
}
