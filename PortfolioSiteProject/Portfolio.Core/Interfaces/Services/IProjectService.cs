using Portfolio.Core.DTOs;
using Portfolio.Entity.Entities;

namespace Portfolio.Core.Interfaces.Services;

public interface IProjectService
{
    Task<List<ProjectDto>> GetAllVisibleAsync();
    Task<List<Project>> GetAllAsync();
}
