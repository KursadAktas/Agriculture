using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.GetListAll();
            return View(values);
        }
        public IActionResult Delete(int id)
        {
            var values = _contactService.GetById(id);
            _contactService.Delete(values);
            return View(values);
        }

        [HttpGet]

        public IActionResult Update(int id)
        {
            var value = _contactService.GetById(id);
            return View(value);
        }
    }
}
