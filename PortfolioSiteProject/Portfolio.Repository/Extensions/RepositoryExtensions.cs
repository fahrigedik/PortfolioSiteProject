using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Portfolio.Core.Interfaces.Repositories;
using Portfolio.Core.Interfaces.UnitOfWork;
using Portfolio.Repository.Repositories;
using Portfolio.Repository.UnitOfWorks;
using System.Reflection;

namespace Portfolio.Repository.Extensions;

public static class RepositoryExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<AppDbContext>(options =>
        {
            var connectionStrings = configuration.GetSection(ConnectionStringOption.Key).Get<ConnectionStringOption>();
            options.UseSqlServer(connectionStrings!.SqlCon, sqlServerOptionsAction =>
            {
                sqlServerOptionsAction.MigrationsAssembly(typeof(RepositoryAssembly).Assembly.FullName);
            });
        });


        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IExperienceRepository, ExperienceRepository>();
        services.AddScoped<IHeroSectionRepository, HeroSectionRepository>();
        services.AddScoped<ISkillRepository, SkillRepository>();
        services.AddScoped<ISocialLinkRepository, SocialLinkRepository>();
        services.AddScoped<IUserInfoRepository, UserInfoRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}

