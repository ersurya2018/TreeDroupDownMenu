using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreeFormMenu.DB_Connect_EF;

namespace TreeFormMenu.Controllers
{
    public class HomeController : Controller
    {
        TreeMenuEntities dbobj = new TreeMenuEntities();
        [HttpGet]
        public ActionResult Index()
        {
            //ViewBag.Country = new SelectList(dbobj.countries, "Id", "name");
            return View();
        }
        public JsonResult Country()
        {
            
            var cres = new SelectList(dbobj.countries, "Id", "name");
            return Json(new { data = cres}, JsonRequestBehavior.AllowGet);
        }
        public JsonResult State(int country_id)
        {

            var sres = new SelectList (dbobj.States.Where(m => m.country.id == country_id), "id", "name");
            return Json(sres, JsonRequestBehavior.AllowGet);

        }
        public JsonResult city(int state_id)
        {
            var cres = new SelectList(dbobj.Cities.Where(m => m.State.id == state_id), "id", "name");
            return Json(cres, JsonRequestBehavior.AllowGet);
        }


    }
}