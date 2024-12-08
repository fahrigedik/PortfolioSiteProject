using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Entity.Entities;
using Portfolio.Service.Services;

namespace Portfolio.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SocialLinkController(ISocialLinkService socialLinkService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var socialLinks = await socialLinkService.GetAllAsync();
            return View(socialLinks);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var socialLink = await socialLinkService.GetByIdAsync(id);
            return View(socialLink);
        }

        [HttpPost]
        public async Task<IActionResult> Update(SocialLink requestModel)
        {
            socialLinkService.UpdateAsync(requestModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await socialLinkService.DeleteAsync(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SocialLink requestModel)
        {
            await socialLinkService.CreateAsync(requestModel);
            return RedirectToAction("Index");
        }
    }
}
