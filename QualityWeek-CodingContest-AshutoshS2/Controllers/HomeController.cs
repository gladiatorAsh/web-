using QualityWeek_CodingContest_AshutoshS2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QualityWeek_CodingContest_AshutoshS2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult GetWord(NumberModel number)
        {
            string output = number.Amount.ToWord();
            TempData["output"] = output;
            return RedirectToAction("Index");

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}