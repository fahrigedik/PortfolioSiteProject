using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Entity.Entities;

namespace Portfolio.Admin.Controllers
{
    public class HeroSectionController(IHeroSectionService heroSectionService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var heroSections = await heroSectionService.GetAllAsync();
            return View(heroSections);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var heroSection = await heroSectionService.GetByIdAsync(id);
            return View(heroSection);
        }

        [HttpPost]
        public async Task<IActionResult> Update(HeroSection requestModel)
        { 
            heroSectionService.UpdateAsync(requestModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await heroSectionService.DeleteAsync(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(HeroSection requestModel)
        {
            await heroSectionService.CreateAsync(requestModel);
            return RedirectToAction("Index");
        }
    }
}
