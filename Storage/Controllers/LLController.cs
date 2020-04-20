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


        public ActionResult Listfenye1(int pageindex,int pagesize)
        {
            return Json(BLL.LL.KweiGuanliManager.Listfenye(pageindex, pagesize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Listfenye2(int pageindex, int pagesize)
        {
            return Json(BLL.LL.GYSguanliManager.Listfenye(pageindex, pagesize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Listfenye3(int pageindex, int pagesize)
        {
            return Json(BLL.LL.KHguanliManager.Listfenye(pageindex, pagesize), JsonRequestBehavior.AllowGet);
        }
    }
}