using OnePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnePage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult _Slider()
        {
            return View(db.Sliderlar.ToList());
        }

        public ActionResult _DugunDetay()
        {
            return View(db.DugunDetay.FirstOrDefault()); //new Dugun(){..}
        }

        public ActionResult _Hikaye()
        {
            HikayeViewModel h = new HikayeViewModel();
            h.Gelin = db.DugunDetay.First().GelinIsim;
            h.Damat = db.DugunDetay.First().DamatIsim;
            h.Hikaye = db.Hikaye.First();
            return View(h);


            //programın hata vermemesi için dtabase oluşturduktan sonra tabloların içini bir kaç tane doldurmak lazım yoksa hata veriyor.
        }
    }
}