using Microsoft.AspNetCore.Mvc;

namespace BusTransport.Web.Areas.Passenger.Controllers
{
    [Area("Passenger")]
    public class LoggedInOnlyController : Controller
    {
        public IActionResult LoggedInOnly()
        {
            return View();
        }
    }
}
