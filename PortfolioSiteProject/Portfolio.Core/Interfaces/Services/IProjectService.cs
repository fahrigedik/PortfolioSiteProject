using Portfolio.Core.DTOs;

namespace Portfolio.Core.Interfaces.Services;

public interface IProjectService
{
    Task<List<ProjectDto>> GetAllListAsync();
}
