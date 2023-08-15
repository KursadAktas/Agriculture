using Agriculture.WebUI.Models;
using ClosedXML.Excel;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace Agriculture.WebUI.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticReport()
        {

            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            ExcelPackage excelPackage = new ExcelPackage();
            var workBook = excelPackage.Workbook.Worksheets.Add("Dosya1");

            workBook.Cells[1, 1].Value = "Ürün Adı";
            workBook.Cells[1, 2].Value = "Ürün Kategorisi";
            workBook.Cells[1, 3].Value = "Ürün Stok";

            workBook.Cells[2, 1].Value = "Mercimek";
            workBook.Cells[2, 2].Value = "Bakliyat";
            workBook.Cells[2, 3].Value = "785 Kg";

            workBook.Cells[3, 1].Value = "Buğday";
            workBook.Cells[3, 2].Value = "Bakliyat";
            workBook.Cells[3, 3].Value = "1.986 Kg";

            workBook.Cells[4, 1].Value = "Havuç";
            workBook.Cells[4, 2].Value = "Sebze";
            workBook.Cells[4, 3].Value = "167 Kg";

            var bytes = excelPackage.GetAsByteArray();
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BakliyatRaporu.xlsx"); //yukarıdaki listeyi dosyaya çevirip kaydediyoruz.
        }

        public List<ContactViewModel> ContactList() //listeyi yapıldı
        {
            List<ContactViewModel> contactModels = new List<ContactViewModel>();
            using(var context = new AgricultureContext())
            {
                contactModels =context.Contacts.Select(x=> new ContactViewModel
                {
                    ContactID = x.ContactId,
                    ContactName =x.Name,
                    ContactDate=x.Date,
                    ContactMail =x.Mail,
                    ContactMessage =x.Message,

                }).ToList();
                    
                return contactModels;
                
            }
        }
        public  IActionResult ContactReport() //listeyi view çekeceğiz
        {
            using(var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Mesaj Listesi");
                workSheet.Cell(1, 1).Value = "Mesaj ID";
                workSheet.Cell(1, 2).Value = "Mesaj Gönderen";
                workSheet.Cell(1, 3).Value = "Mesaj Adresi";
                workSheet.Cell(1, 4).Value = "Mesaj İçeriği";
                workSheet.Cell(1, 5).Value = "Mesaj Tarihi";

                int contactRowCount = 2;
                foreach (var item in ContactList())
                {
                    workSheet.Cell(contactRowCount, 1).Value = item.ContactID;//satır sayısı bilinmediğinden listeden gelen değer olacak
                    workSheet.Cell(contactRowCount,2).Value = item.ContactName;
                    workSheet.Cell(contactRowCount,3).Value = item.ContactMail;
                    workSheet.Cell(contactRowCount,4).Value = item.ContactMessage;
                    workSheet.Cell(contactRowCount,5).Value = item.ContactDate;

                    contactRowCount++; //bir sonraki satıra geçer
                }
                using(var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Mesaj Rapor.xlsx");
                }
            }
           


        }
        public List<AnnouncementModel> AnnouncementList() //listeyi yapıldı
        {
            List<AnnouncementModel> announcementModel = new List<AnnouncementModel>();
            using (var context = new AgricultureContext())
            {
                announcementModel = context.Announcements.Select(x => new AnnouncementModel
                {
                    AnnouncementId = x.AnnouncementId,
                    Title = x.Title,
                    Date = x.Date,
                    Description = x.Description,
                    Status = x.Status,

                }).ToList();

                return announcementModel;

            }
        }
        public IActionResult AnnouncementReport() //listeyi view çekeceğiz
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Duyuru Listesi");
                workSheet.Cell(1, 1).Value = "Duyuru ID";
                workSheet.Cell(1, 2).Value = "Duyuru Başlığı";
                workSheet.Cell(1, 3).Value = "Duyuru Tarihi";
                workSheet.Cell(1, 4).Value = "Duyuru İçeriği";
                workSheet.Cell(1, 5).Value = "Durum";

                int contactRowCount = 2;
                foreach (var item in AnnouncementList())
                {
                    workSheet.Cell(contactRowCount, 1).Value = item.AnnouncementId;//satır sayısı bilinmediğinden listeden gelen değer olacak
                    workSheet.Cell(contactRowCount, 2).Value = item.Title;
                    workSheet.Cell(contactRowCount, 3).Value = item.Date;
                    workSheet.Cell(contactRowCount, 4).Value = item.Description;
                    workSheet.Cell(contactRowCount, 5).Value = item.Status;

                    contactRowCount++; //bir sonraki satıra geçer
                }
                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Duyuru Rapor.xlsx");
                }
            }



        }

    }
}
