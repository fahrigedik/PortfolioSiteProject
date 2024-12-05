using Portfolio.Core.DTOs;

namespace Portfolio.Core.Interfaces.Services;

public interface ISkillService
{
    Task<List<SkillDto>> GetAllListAsync();
}

