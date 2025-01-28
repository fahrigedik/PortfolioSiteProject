using AutoMapper.Configuration.Annotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Entity.Entities;

namespace Portfolio.Web.Controllers
{
    public class UserInfoController : BaseAdminController
    {
        private readonly IUserInfoService _userInfoService;
        public UserInfoController(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }
        public async Task<IActionResult> Index()
        {
            var userInfos = await _userInfoService.GetAllAsync();
            return View(userInfos);
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserInfo requestModel)
        {
            await _userInfoService.CreateAsync(requestModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var userInfo = await _userInfoService.GetByIdAsync(id);
            return View(userInfo);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserInfo requestModel)
        {
            await _userInfoService.UpdateAsync(requestModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _userInfoService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
