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
        public ActionResult KwselectAll() {
            return Json(BLL.LL.Location_managementBLL.selectAll(),JsonRequestBehavior.AllowGet);
        }
        public ActionResult GysselectAll()
        {
            return Json(BLL.LL.supplierBLL.selectAll(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult KhselectAll()
        {
            return Json(BLL.LL.clientBLL.selectAll(), JsonRequestBehavior.AllowGet);
        }

    }
}