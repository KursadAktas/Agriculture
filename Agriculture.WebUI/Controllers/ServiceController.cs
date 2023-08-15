using Agriculture.WebUI.Models;
using BusinessLayer.Abstract;
using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;
        AgricultureContext context = new AgricultureContext();
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values = _serviceService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddServise()
        {
            return View(new ServiceAddViewModel());
        }
        [HttpPost]
        public IActionResult AddServise(ServiceAddViewModel model)
        {
            if (ModelState.IsValid) // model içerindeki şartlar sağlanmıyorsa
            {
                _serviceService.Insert(new Service()
                {
                    Title = model.Title,
                    Image = model.Image,
                    Description = model.Description,

                });
                return RedirectToAction("Index");
            }
            return View(model);
            
        }
        public IActionResult Delete(int id)
        {
            var values = _serviceService.GetById(id);
            _serviceService.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]   
        public IActionResult Update(int id)
        {
            var values = _serviceService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Update(Service service)
        {
            _serviceService.Update(service);
            return RedirectToAction("Index");
        }

        public IActionResult Deneme() 
        {
            return View();
        }

    }
}
