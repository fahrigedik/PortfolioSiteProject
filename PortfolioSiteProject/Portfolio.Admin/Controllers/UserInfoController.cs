using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Entity.Entities;
using Portfolio.Service.Services;

namespace Portfolio.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserInfoController(IUserInfoService userInfoService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var userInfos = await userInfoService.GetAllAsync();
            return View(userInfos);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var userInfo = await userInfoService.GetByIdAsync(id);
            return View(userInfo);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserInfo requestModel)
        {
            userInfoService.UpdateAsync(requestModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await userInfoService.DeleteAsync(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserInfo requestModel)
        {
            await userInfoService.CreateAsync(requestModel);
            return RedirectToAction("Index");
        }
    }
}
