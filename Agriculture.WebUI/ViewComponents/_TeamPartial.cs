using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.ViewComponents
{
	public class _TeamPartial : ViewComponent
	{
		private readonly ITeamService _serviceTeam;

		public _TeamPartial(ITeamService serviceTeam)
		{
			_serviceTeam = serviceTeam;
		}

		public IViewComponentResult Invoke()
		{
			var values = _serviceTeam.GetListAll();
			return View(values);
		}
	}
}
