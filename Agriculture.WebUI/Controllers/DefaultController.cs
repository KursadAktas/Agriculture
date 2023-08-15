using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.Controllers
{
    [AllowAnonymous] //Login olmadan görünecek sayfa bir nevi izin
    public class DefaultController : Controller
    {
        private readonly IContactService _contactService;

		public DefaultController(IContactService contactService)
		{
			_contactService = contactService;
		}

		public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage() //ana sayfa üzerinden mesaj alacağız buradan tanımlıyorum
        {
            return PartialView();
        }

		[HttpPost]
		public IActionResult SendMessage(Contact contact) //ana sayfa üzerinden mesaj alacağız buradan tanımlıyorum
		{
            contact.Date= DateTime.Now;
            _contactService.Insert(contact);
			return RedirectToAction("Index","Default");
		}
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
	}
}
