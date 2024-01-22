using Microsoft.AspNetCore.Mvc;

namespace BusTransport.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginRegisterController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
