using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicaretOtomasyon.Models.Sınıflar;

namespace MvcOnlineTicaretOtomasyon.Controllers
{
    public class FaturalarController : Controller
    {
        // GET: Faturalar
        Context c = new Context();
        public ActionResult Index()
        {
            var liste = c.Faturalars.ToList();
            return View(liste);
        }

        [HttpGet]
        public ActionResult faturaEkle()
        {

            return View();
        }

        [HttpPost]
        public ActionResult faturaEkle(Faturalar f)
        {
            c.Faturalars.Add(f);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult faturaGetir(int id)
        {
            var fatura = c.Faturalars.Find(id);
            return View("faturaGetir", fatura);
        }
        public ActionResult faturaGuncelle(Faturalar f)
        {
            var fatura = c.Faturalars.Find(f.FaturaId);
            fatura.FaturaSerino = f.FaturaSerino;
            fatura.FaturaSırano = f.FaturaSırano;
            fatura.Saat = f.Saat;
            fatura.Tarih = f.Tarih;
            fatura.TeslimAlan = f.TeslimAlan;
            fatura.TeslimEden = f.TeslimEden;
            fatura.VergiDairesi = f.VergiDairesi;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult faturaDetay(int id)
        {
            var degerler = c.FaturaKalems.Where(x => x.faturaId == id).ToList();
            return View(degerler);

        }
        [HttpGet]
        public ActionResult yeniKalem()
        {
            return View();

        }
        [HttpPost]
        public ActionResult yeniKalem(FaturaKalem f)
        {
            c.FaturaKalems.Add(f);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}