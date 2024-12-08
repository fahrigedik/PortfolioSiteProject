using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Entity.Entities;
using Portfolio.Service.Services;

namespace Portfolio.Admin.Controllers
{
    public class SkillController(ISkillService skillService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var skills = await skillService.GetAllAsync();
            return View(skills);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var skill = await skillService.GetByIdAsync(id);
            return View(skill);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Skill requestModel)
        {
            skillService.UpdateAsync(requestModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await skillService.DeleteAsync(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Skill requestModel)
        {
            await skillService.CreateAsync(requestModel);
            return RedirectToAction("Index");
        }
    }
}
