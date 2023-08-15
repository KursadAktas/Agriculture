using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.ViewComponents
{
	public class _GaleryPartial : ViewComponent
	{
		private readonly IImageService _imageService;

		public _GaleryPartial(IImageService imageService)
		{
			_imageService = imageService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _imageService.GetListAll();
			return View(values);
		}
	}
}
