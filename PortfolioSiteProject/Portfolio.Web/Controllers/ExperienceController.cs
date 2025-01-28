using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Entity.Entities;

namespace Portfolio.Web.Controllers
{
    public class ExperienceController : BaseAdminController
    {
        private readonly IExperienceService _experienceService;

        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        public async Task<IActionResult> Index()
        {
            var experiences = await _experienceService.GetAllAsync();
            return View(experiences);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Experience requestModel)
        {
            await _experienceService.CreateAsync(requestModel);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var experience = await _experienceService.GetByIdAsync(id);
            return View(experience);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Experience requestModel)
        {
            await _experienceService.UpdateAsync(requestModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _experienceService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
