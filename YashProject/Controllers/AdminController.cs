using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YashProject.Models;

namespace YashProject.Controllers
{
    
    public class AdminController : Controller
    {
        DB_JewelleryEntities entities = new DB_JewelleryEntities();
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Gold()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Gold(GoldKrtMst ab)
        {
            entities.GoldKrtMsts.Add(new GoldKrtMst { GoldType_ID = ab.GoldType_ID, Gold_Crt = ab.Gold_Crt });
            entities.SaveChanges();
            return View();
        }
    }
}