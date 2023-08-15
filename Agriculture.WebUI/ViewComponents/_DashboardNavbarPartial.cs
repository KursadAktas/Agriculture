using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.ViewComponents
{
    public class _DashboardNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View(); 
        }

    }
}
