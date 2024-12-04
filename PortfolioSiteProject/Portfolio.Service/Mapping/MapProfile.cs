using AutoMapper;
using Portfolio.Core.DTOs;
using Portfolio.Entity.Entities;

namespace Portfolio.Repository.Mapping;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<HeroSection, HeroSectionDto>();
        CreateMap<Skill, SkillDto>();
        CreateMap<Experience, ExperienceDto>();
        CreateMap<SocialLink, SocialLinkDto>();
        CreateMap<UserInfo, UserInfoDto>();
    }
}

