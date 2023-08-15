using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.ViewComponents
{
	public class _SocialMediaPartial :ViewComponent
	{
		private readonly ISocialMediaService _socialMeadia;

		public _SocialMediaPartial(ISocialMediaService socialMeadia)
		{
			_socialMeadia = socialMeadia;
		}

		public IViewComponentResult Invoke()
		{
			var values = _socialMeadia.GetListAll();

			return View(values);
		}
	}
}
