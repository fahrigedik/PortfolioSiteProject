using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Entity.Entities;
using Portfolio.Service.Services;

namespace Portfolio.Admin.Controllers
{

    [Authorize(Roles = "Admin")]
    public class ExperienceController(IExperienceService experienceService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var experiences = await experienceService.GetAllAsync();
            return View(experiences);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var experience = await experienceService.GetByIdAsync(id);
            return View(experience);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Experience requestModel)
        {
            experienceService.UpdateAsync(requestModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await experienceService.DeleteAsync(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Experience requestModel)
        {
            await experienceService.CreateAsync(requestModel);
            return RedirectToAction("Index");
        }
    }
}
