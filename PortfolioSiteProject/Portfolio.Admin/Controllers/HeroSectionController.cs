using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Admin.Controllers
{
    public class HeroSectionController(IHeroSectionService heroSectionService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var heroSections = await heroSectionService.GetAllAsync();

            return View(heroSections);
        }
    }
}
