using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicaretOtomasyon.Models.Sınıflar;
namespace MvcOnlineTicaretOtomasyon.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Kategoris.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult kategoriEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult kategoriEkle(Kategori k)
        {
            c.Kategoris.Add(k);
            c.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult kategoriSil(int id)
        {
            var ktg = c.Kategoris.Find(id);
            c.Kategoris.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult kategoriGetir(int id)
        {
            var ktg = c.Kategoris.Find(id);
            c.SaveChanges();
            return View("kategoriGetir", ktg);
        }
        public ActionResult kategoriGuncelle(Kategori k)
        {
            var ktg = c.Kategoris.Find(k.KategoryId);
            ktg.KategoryAd = k.KategoryAd;
            c.SaveChanges();
            return RedirectToAction("index");
        }
    }
}