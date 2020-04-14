using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;


namespace Storage.Controllers
{
    public class LLQController : Controller
    {
        // GET: LLQ
        public ActionResult Jldw()
        {
            return View();
        }

        public ActionResult Cplb()
        {
            return View();
        }

        public ActionResult Indexs(int PageSize)
        {
            return Json(BLL.LLQ.CplbManager.GetCount(PageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAll(int PageIndex, int PageSize, Models.CpLbinfo Cplb)
        {
            return Json(BLL.LLQ.CplbManager.lb(PageIndex, PageSize, Cplb), JsonRequestBehavior.AllowGet);
        }

        public ActionResult CpGl()
        {
            return View();
        }
    }
}