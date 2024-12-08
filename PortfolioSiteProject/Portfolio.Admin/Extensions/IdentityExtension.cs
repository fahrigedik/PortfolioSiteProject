using Microsoft.AspNetCore.Identity;
using Portfolio.Entity.Identity;
using Portfolio.Repository;

namespace Portfolio.Admin.Extensions
{
    public static class IdentityExtension
    {
        public static IServiceCollection AddIdentityExtension(this IServiceCollection services)
        {
            // Identity Core yapılandırması
            var identityBuilder = services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = true;
            })
            .AddEntityFrameworkStores<AppDbContext>() // Doğru bir şekilde bağla
            .AddDefaultTokenProviders(); // Token desteği için

            // Admin rolü ve yönetici kullanıcıyı oluştur
            var serviceProvider = services.BuildServiceProvider();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<AppRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();

            // Admin rolü oluşturulmamışsa oluştur
            if (!roleManager.RoleExistsAsync("Admin").GetAwaiter().GetResult())
            {
                var role = new AppRole { Name = "Admin" };
                roleManager.CreateAsync(role).GetAwaiter().GetResult();
            }

            // Yeni Admin kullanıcı yaratın
            var adminUser = new AppUser
            {
                UserName = "admin@example.com",
                Email = "admin@example.com",
                EmailConfirmed = true
            };

            var result = userManager.CreateAsync(adminUser, "AdminPassword123!").GetAwaiter().GetResult();
            if (result.Succeeded)
            {
                userManager.AddToRoleAsync(adminUser, "Admin").GetAwaiter().GetResult();
            }

            return services;
        }
    }
}
