using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicaretOtomasyon.Models.Sınıflar;

namespace MvcOnlineTicaretOtomasyon.Controllers
{
    public class CarilerController : Controller
    {
        // GET: Cariler
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Carilers.Where(x=>x.Durum==true).ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult yeniCari()
        {
            return View();
        }
        [HttpPost]
        public ActionResult yeniCari(Cariler p)
        {
            p.Durum= true;
            c.Carilers.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CariSil(int id)
        {
            var cr = c.Carilers.Find(id);
            cr.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CariGetir(int id)
        {
            var cr = c.Carilers.Find(id);
            return View("CariGetir",cr);
        }
        public ActionResult CariGuncelle(Cariler p)
        {
            var cr = c.Carilers.Find(p.CariId);
            cr.CariAd = p.CariAd;
            cr.CariSoyad = p.CariSoyad;
            cr.CariSehir = p.CariSehir;
            cr.CariMail = p.CariMail;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MusteriSatis(int id)
        {
            var degerler = c.SatisHarekets.Where(x=>x.cariId == id).ToList();
            return View(degerler);
        }

    }
}