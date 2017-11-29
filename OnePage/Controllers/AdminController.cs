using OnePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnePage.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Slider()
        {
            return View();
        }


        /*
        Dosya upload için:
        1. formda mutlaka enctype="multipart/form-data" olmalı
        2. input type="file" name="oylesine"
        3. ActionResult Yukle (HttpPostedFileBase oylesine)
             */

        ApplicationDbContext db = new ApplicationDbContext();

        [HttpPost]
        public ActionResult Slider(Slider s, HttpPostedFileBase resim)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    #region ResimDosyasiKaydet
                    //MapPath kesin yolu getirir. Klasör yolu için kullanırız.
                    string klasorYolu = Server.MapPath("/Content/uploads");

                    var resimAdi = Guid.NewGuid().ToString();

                    string yol = klasorYolu + "/" + resimAdi + ".jpg";
                    //veya
                    yol = String.Format("{0}/{1}.jpg", klasorYolu, resimAdi);
                    //veya
                    yol = System.IO.Path.Combine(klasorYolu, resimAdi)+ ".jpg";
                    //veya String Builder

                    //SaveAs metodu absolute path ile çalışır
                    resim.SaveAs(yol);
                    #endregion
                    #region DbyeKaydet
                    s.ResimURL = resimAdi + ".jpg";
                    db.Sliderlar.Add(s);
                    db.SaveChanges();
                    ViewBag.Sonuc = "Başarıyla kaydedildi.";
                    #endregion
                }
                catch (System.IO.IOException ex)
                {
                    ViewBag.Sonuc = "Dosya yüklenirken bir hata oluştu. Detay: "+ex.Message;
                }
                catch(Exception ex)
                {
                    ViewBag.Sonuc = "Genel bir hata meydana geldi. Detay: " + ex.Message;
                }
            }
            return View();
        }
    }
}