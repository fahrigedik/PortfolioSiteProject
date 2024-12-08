using Portfolio.Core.DTOs;
using Portfolio.Entity.Entities;

namespace Portfolio.Core.Interfaces.Services;

public interface IExperienceService
{
    Task<List<ExperienceDto>> GetAllVisibleAsync();

    Task<List<Experience>> GetAllAsync();
}