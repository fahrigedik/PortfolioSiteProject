using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Service.Services;

namespace Portfolio.Service.Extensions;
public static class ServiceExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IExperienceService, ExperienceService>();
        services.AddScoped<IHeroSectionService, HeroSectionService>();
        services.AddScoped<ISkillService, SkillService>();
        services.AddScoped<ISocialLinkService, SocialLinkService>();
        services.AddScoped<IUserInfoService, UserInfoService>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}
