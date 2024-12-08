using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Web.ViewComponents;

public class ProjectSectionViewComponent(IProjectService projectService) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var projects = await projectService.GetAllVisibleAsync();
        return View(projects);
    }
}

