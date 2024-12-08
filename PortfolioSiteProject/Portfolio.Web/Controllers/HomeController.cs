using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Models;
using System.Diagnostics;
using Portfolio.Core.Interfaces.Services;

namespace Portfolio.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserInfoService _userInfoService;

        public HomeController(ILogger<HomeController> logger, IUserInfoService userInfoService)
        {
            _logger = logger;
            _userInfoService = userInfoService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _userInfoService.GetAllVisibleAsync();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
