using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.Controllers
{

    [Authorize(Roles = "Admin")]
    public class BaseAdminController : Controller
    {

    }
}
