using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Entity.Entities;
using Portfolio.Service.Services;

namespace Portfolio.Web.Controllers
{
    public class ProjectController : BaseAdminController
    {
        private readonly IProjectService projectService;
        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }
        public async Task<IActionResult> Index()
        {
            var projects = await projectService.GetAllAsync();
            return View(projects);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var project = await projectService.GetByIdAsync(id);
            return View(project);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Project requestModel)
        {
            projectService.UpdateAsync(requestModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await projectService.DeleteAsync(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Project requestModel)
        {
            await projectService.CreateAsync(requestModel);
            return RedirectToAction("Index");
        }
    }
}
