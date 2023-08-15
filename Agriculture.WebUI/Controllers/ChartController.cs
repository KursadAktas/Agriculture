using Agriculture.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult  ProductChart()
        {
            ViewBag.p1 = 80;
            ViewBag.u1 = 88;
            ViewBag.u2 = 93;
            ViewBag.u3 = 93;

            List<ProductViewModel> productsClasses = new List<ProductViewModel>();
            productsClasses.Add(new ProductViewModel
            {
                productname = "Buğday",
                productvalue = 850
            });
            productsClasses.Add(new ProductViewModel
            {
                productname = "Mercimek",
                productvalue = 480
            });

            productsClasses.Add(new ProductViewModel
            {
                productname = "Arpa",
                productvalue = 600
            });
            productsClasses.Add(new ProductViewModel
            {
                productname = "Pirinç",
                productvalue = 380
            });
            productsClasses.Add(new ProductViewModel
            {
                productname = "Domates",
                productvalue = 960
            });
            return Json(new {jsonList = productsClasses});
            //json grafiğe aktarmak için kullanılır.
        }
    }
}
