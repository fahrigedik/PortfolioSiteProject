using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Service.Services;
public class ProjectService(IProjectRepository projectRepository, IMapper mapper) : IProjectService
{
    public async Task<List<ProjectDto>> GetAllListAsync()
    {
        var projects = await projectRepository.GetAllAsync();
        var projectDtos = mapper.Map<List<ProjectDto>>(projects);
        return projectDtos;
    }
}

