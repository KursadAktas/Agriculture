using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.ViewComponents
{
	public class _AnnoucementPartial :ViewComponent
	{
		private readonly IAnnouncementService _announcementService;

		public _AnnoucementPartial(IAnnouncementService announcementService)
		{
			_announcementService = announcementService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _announcementService.GetListAll();
			return View(values);
		}
	}
}
