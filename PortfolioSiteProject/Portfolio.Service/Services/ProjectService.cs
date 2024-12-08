using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Interfaces.UnitOfWork;
using Portfolio.Entity.Entities;
using Portfolio.Repository.Repositories;
using Portfolio.Repository.UnitOfWorks;

namespace Portfolio.Service.Services;
public class ProjectService(IProjectRepository projectRepository, IUnitOfWork unitOfWork, IMapper mapper) : IProjectService
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

    public async Task<Project> GetByIdAsync(Guid id)
    {
        var project = await projectRepository.GetByIdAsync(id);
        return project;
    }

    public async Task UpdateAsync(Project requestModel)
    {
        projectRepository.Update(requestModel);
        unitOfWork.SaveChanges();
    }

    public async Task DeleteAsync(Guid id)
    {
        var project = await projectRepository.GetByIdAsync(id);
        projectRepository.Delete(project);
        unitOfWork.SaveChanges();
    }

    public async Task CreateAsync(Project requestModel)
    {
        await projectRepository.AddAsync(requestModel);
        unitOfWork.SaveChanges();
    }
}

