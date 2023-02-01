using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.Context;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcUI.Data;
using MvcUI.Models;
using System.ComponentModel.DataAnnotations;

namespace MvcUI.Controllers
{
    public class KayitFormu : Controller
    {
        KisiselBilgilerManager kisisel = new KisiselBilgilerManager(new EfKisiselBilgilerDal());

        bool dogrulamaSonucu, isPost;



        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            IlManager ılManager = new IlManager(new EfIlDal());
            List<SelectListItem> IlValues = (from x in ılManager.GetList()
                                             select new SelectListItem
                                             {
                                                 Text = x.aciklama,
                                                 Value = x.IlId.ToString(),
                                             }).ToList();

            ViewBag.Il = IlValues;

            IlceManager ılceManager = new IlceManager(new EfIlceDal());
            List<SelectListItem> selectListItems = (from x in ılceManager.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.IlceAdi,
                                                        Value = x.IlceId.ToString(),
                                                    }).ToList();
            ViewBag.Ilce = selectListItems;

            MahalleManager mahalleManager = new MahalleManager(new EfMahalleDal());
            List<SelectListItem> mahalleValues = (from x in mahalleManager.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.MahalleAdi,
                                                      Value = x.MahalleId.ToString(),
                                                  }).ToList();
            ViewBag.Mahalle = mahalleValues;

            CaddeManager caddeManager = new CaddeManager(new EfCaddeDal());
            List<SelectListItem> caddeValues = (from x in caddeManager.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.CaddeAdi,
                                                    Value = x.CaddeId.ToString(),
                                                }).ToList();

            ViewBag.Cadde = caddeValues;

            AbonelikTuruManager abonelikTuruManager = new AbonelikTuruManager(new EfAbonelikTuruDal());
            List<SelectListItem> AbonelikValues = (from x in abonelikTuruManager.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.AboneTuru,
                                                       Value = x.AboneTurId.ToString(),
                                                   }).ToList();

            ViewBag.AbonelikTuru = AbonelikValues;

            MeslekKodlariManager meslekKodlariManager = new MeslekKodlariManager(new EfMeslekKodlariDal());
            List<SelectListItem> meslekKodlariValues = (from x in meslekKodlariManager.GetList()
                                                        select new SelectListItem
                                                        {
                                                            Text = x.MeslekAdi,
                                                            Value = x.MeslekId.ToString(),
                                                        }).ToList();

            ViewBag.MeslekKodu = meslekKodlariValues;

            NumaralarManager numaralarManager = new NumaralarManager(new EfNumaralarDal());
            List<SelectListItem> numaralarValues = (from x in numaralarManager.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.NumaraNo,
                                                        Value = x.NumaraId.ToString(),
                                                    }).ToList();

            ViewBag.Numaralar = numaralarValues;

            return View();
        }

        [HttpPost]
        public IActionResult Add(KisiselBilgiler kisiselBilgiler)
        {
            

            var tcNo = kisiselBilgiler.TCNO;

            tcNo = TCKimlikKontrol.Kontrol(tcNo);


            if (kisiselBilgiler.TCNO != tcNo)
            {
                TempData["hata"] = "girmiş olduğunuz bilgiler hatalıdır.";
            }
            else
            {
                kisisel.KisiselBilgilerAdd(kisiselBilgiler);
                return RedirectToAction("Index", "Home");

            }
            return View();
        }

        public JsonResult ilcegetir(int p)
        {
            BasvuruContext context = new BasvuruContext();

            var ilceler = (from x in context.Ilces
                           join y in context.Ils on x.IlId equals y.IlId
                           where x.IlId == p
                           select new
                           {
                               Text = x.IlceAdi,
                               Value = x.IlceId.ToString()
                           }).ToList();

            return Json(ilceler);
        }

        public JsonResult mahallegetir(int p)
        {
            BasvuruContext context = new BasvuruContext();

            var mahalleler = (from x in context.Mahalles
                              join y in context.Ilces on x.IlceId equals y.IlceId
                              where x.IlceId == p
                              select new
                              {
                                  Text = x.MahalleAdi,
                                  Value = x.MahalleId.ToString()
                              }).ToList();

            return Json(mahalleler);
        }

        public JsonResult caddegetir(int p)
        {
            BasvuruContext context = new BasvuruContext();

            var caddeler = (from x in context.Caddes
                            join y in context.Mahalles on x.MahalleId equals y.MahalleId
                            where x.MahalleId == p
                            select new
                            {
                                Text = x.CaddeAdi,
                                Value = x.CaddeId.ToString()
                            }).ToList();

            return Json(caddeler);
        }
    }
}
