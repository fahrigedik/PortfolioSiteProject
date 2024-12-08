using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Web.ViewComponents;

public class SkillSectionViewComponent(ISkillService skillService) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var skills = await skillService.GetAllVisibleAsync();
        return View(skills);
    }
}

