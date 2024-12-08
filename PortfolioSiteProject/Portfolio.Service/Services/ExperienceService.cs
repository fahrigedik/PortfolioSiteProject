using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Interfaces.UnitOfWork;
using Portfolio.Entity.Entities;
using Portfolio.Repository.Repositories;
using Portfolio.Repository.UnitOfWorks;

namespace Portfolio.Service.Services;
public class ExperienceService(IExperienceRepository experienceRepository,IUnitOfWork unitOfWork, IMapper mapper) : IExperienceService
{
    public async Task<List<ExperienceDto>> GetAllVisibleAsync()
    {
        var experiences = await experienceRepository.GetAllVisibleAsync();
        var experienceDto = mapper.Map<List<ExperienceDto>>(experiences);
        return experienceDto;
    }

    public async Task<List<Experience>> GetAllAsync()
    {
        var experiences = await experienceRepository.GetAllAsync();
        return experiences;
    }

    public async Task<Experience> GetByIdAsync(Guid id)
    {
        var experience = await experienceRepository.GetByIdAsync(id);
        return experience;
    }

    public async Task UpdateAsync(Experience requestModel)
    {
        experienceRepository.Update(requestModel);
        unitOfWork.SaveChanges();
    }

    public async Task DeleteAsync(Guid id)
    {
        var experience = await experienceRepository.GetByIdAsync(id);
        experienceRepository.Delete(experience);
        unitOfWork.SaveChanges();
    }

    public async Task CreateAsync(Experience requestModel)
    {
        await experienceRepository.AddAsync(requestModel);
        unitOfWork.SaveChanges();
    }
}
