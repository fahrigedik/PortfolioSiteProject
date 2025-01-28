using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Helpers;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Entity.Entities;
using Portfolio.Service.Services;

namespace Portfolio.Web.Controllers
{
    public class HeroSectionController : BaseAdminController
    {
        private readonly IHeroSectionService _heroSectionService;
        public HeroSectionController(IHeroSectionService heroSectionService)
        {
            _heroSectionService = heroSectionService;
        }
        public async Task<IActionResult> Index()
        {
            var heroSections = await _heroSectionService.GetAllAsync();
            return View(heroSections);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var heroSection = await _heroSectionService.GetByIdAsync(id);
            return View(heroSection);
        }

        [HttpPost]
        public async Task<IActionResult> Update(HeroSection requestModel, IFormFile ImageFile)
        {
            if (ImageFile != null)
            {
                requestModel.Image = ImageHelper.ConvertToByteArray(ImageFile);
            }
            await _heroSectionService.UpdateAsync(requestModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _heroSectionService.DeleteAsync(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(HeroSection requestModel, IFormFile ImageFile)
        {
            if (ImageFile != null)
            {
                requestModel.Image = ImageHelper.ConvertToByteArray(ImageFile);
            }

            await _heroSectionService.CreateAsync(requestModel);
            return RedirectToAction("Index");
        }
    }
}
