using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebUI.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke() //istatistik alanı verilerin toplam sayısı
        {
            ViewBag.teamCount = c.Teams.Count();
            ViewBag.serviceCount = c.Services.Count();
            ViewBag.messageCount = c.Contacts.Count();
            ViewBag.mountlyMessage = 3;

            ViewBag.announcementTrue=c.Announcements.Where(x=>x.Status == true).Count();
            ViewBag.announcementFalse=c.Announcements.Where(x=>x.Status == false).Count();
            ViewBag.sales = c.Teams.Where(x => x.Title == "Ürün Pazarlama").Select(y => y.PersonelName).FirstOrDefault();
            ViewBag.salesFood = c.Teams.Where(x => x.Title == "Bakliyat Yönetimi").Select(y => y.PersonelName).FirstOrDefault();
            ViewBag.milkProduct = c.Teams.Where(x => x.Title == "Süt Yönetimi").Select(y => y.PersonelName).FirstOrDefault();
            ViewBag.product = c.Teams.Where(x => x.Title == "Gübre Yönetimi").Select(y => y.PersonelName).FirstOrDefault();

            return View();
        }
    }
}
