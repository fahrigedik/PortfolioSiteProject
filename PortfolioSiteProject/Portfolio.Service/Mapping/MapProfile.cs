using AutoMapper;
using Portfolio.Entity.Entities;
using Portfolio.Service.DTOs;

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

