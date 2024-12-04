using Portfolio.Core.DTOs;

namespace Portfolio.Core.Interfaces.Services;

public interface IExperienceService
{
    Task<List<ExperienceDto>> GetAllListAsync();
}