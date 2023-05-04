using Microsoft.AspNetCore.Mvc;

namespace AgencyCore.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
