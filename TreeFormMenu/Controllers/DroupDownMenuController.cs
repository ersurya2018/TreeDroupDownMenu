using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreeFormMenu.DB_Connect_EF;

namespace TreeFormMenu.Controllers
{
    public class DroupDownMenuController : Controller
    {
        // GET: DroupDownMenu
        TreeMenuEntities dbobj = new TreeMenuEntities();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult CountryName()
        {
            var CountyData = new SelectList(dbobj.countries, "ID", "Name");
            return Json(new { data= CountyData }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult StateName(int Country_Id)
        {
            var StateData = new SelectList(dbobj.States.Where(data => data.StateCounty_Id == Country_Id), "ID", "Name");
            return Json(StateData, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CityName(int State_id)
        {
            var CityData = new SelectList(dbobj.Cities.Where(data => data.CityState_Id == State_id), "ID", "Name");
            return Json(CityData, JsonRequestBehavior.AllowGet);
        }
    }
}