using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Web.ViewComponents;

public class ExperienceSectionViewComponent(IExperienceService experienceService) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var experiences = await experienceService.GetAllVisibleAsync();
        return View(experiences);
    }
}

