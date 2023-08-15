using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;



namespace Agriculture.WebUI.Controllers
{
    public class AdressController : Controller
    {
       private readonly IAdressService _adressService;

        public AdressController(IAdressService adressService)
        {
            _adressService = adressService;
        }

        public IActionResult Index()
        {
            var values = _adressService.GetListAll();
            return View(values);
        }
       

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _adressService.GetById(id);
            return View(value);
        }
        [HttpPost]

        public IActionResult Update(Adress adress)
        {
            AdressValidator validationRules = new AdressValidator();
            FluentValidation.Results.ValidationResult result = validationRules.Validate(adress);// gelen değerleri kontrol et
            if (result.IsValid)
            {
                _adressService.Update(adress);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();


        }
    }
}

