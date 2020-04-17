using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace Storage.Controllers
{
    public class LLController : Controller
    {
        // GET: LL
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GYSguanli()
        {
            return View();
        }
        public ActionResult KHguanli()
        {
            return View();
        }


        public ActionResult Listfenye(int pageindex,int pagesize)
        {
            return Json(BLL.LL.KweiGuanliManager.Listfenye(pageindex, pagesize), JsonRequestBehavior.AllowGet);
        }
    }
}