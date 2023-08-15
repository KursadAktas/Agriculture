using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
