using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.ViewComponents
{
    public class _DashboardScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
