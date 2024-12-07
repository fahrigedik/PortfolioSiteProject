using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Web.ViewComponents;

public class UserInfoViewComponent(IUserInfoService userInfoService) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var userInfoServices = (await userInfoService.GetAllListAsync()).First();

        return View(userInfoServices);
    }
}

