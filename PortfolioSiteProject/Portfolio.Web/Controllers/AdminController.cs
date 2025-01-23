using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.Controllers
{
    public class AdminController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
