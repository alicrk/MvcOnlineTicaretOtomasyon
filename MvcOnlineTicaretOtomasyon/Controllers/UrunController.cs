using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicaretOtomasyon.Models.Sınıflar;
namespace MvcOnlineTicaretOtomasyon.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        Context c = new Context();
        public ActionResult Index()
        {
            var urunler = c.Uruns.ToList();

            return View(urunler);
        }
        [HttpGet]
        public ActionResult yeniUrun()
        {
            return View();
        }
        [HttpPost]
        public ActionResult yeniUrun(Urun p)
        {
            var urun = c.Uruns.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}