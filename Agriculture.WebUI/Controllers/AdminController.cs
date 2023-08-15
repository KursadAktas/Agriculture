using BusinessLayer.Abstract;
using DataAccessLayer.Contexts;
using DocumentFormat.OpenXml.InkML;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Agriculture.WebUI.Controllers
{

	public class AdminController : Controller
	{
        AgricultureContext _context = new AgricultureContext();
        private readonly IAdminService _adminService;

		public AdminController(IAdminService adminService)
		{
			_adminService = adminService;
		}
        public IActionResult Index()
		{
            var values = _context.Admins.Where(x => x.IsDeleted == false).ToList();
            return View(values);
        }

		[HttpGet]
		public IActionResult AddAdmin()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddAdmin(Admin admin)
		{
			_adminService.Insert(admin);
			return RedirectToAction("Index");
		}

		public IActionResult Delete(int id)
		{
			
            var value = _context.Admins.Where(x => x.AdminId == id).FirstOrDefault();
            value.IsDeleted = true;
            _context.Update(value);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
		[HttpGet]
		public IActionResult Update(int id)
		{
			var value = _adminService.GetById(id);

			return View(value);
		}
        [HttpPost]
        public IActionResult Update(Admin admin)
        {
            _adminService.Update(admin);
            return RedirectToAction("Index");
        }
    }
}
