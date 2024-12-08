using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Entity.Entities;

namespace Portfolio.Service.Services;
public class ProjectService(IProjectRepository projectRepository, IMapper mapper) : IProjectService
{
    public async Task<List<ProjectDto>> GetAllVisibleAsync()
    {
        var projects = await projectRepository.GetAllVisibleAsync();
        var projectDtos = mapper.Map<List<ProjectDto>>(projects);
        return projectDtos;
    }

    public async Task<List<Project>> GetAllAsync()
    {
        var projects = await projectRepository.GetAllAsync();
        return projects;
    }
}

