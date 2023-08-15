using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.ViewComponents
{
	public class _HeadPartial : ViewComponent
	{
		public IViewComponentResult Invoke()  //standar 
		{
			return View();
		}
	}
}
