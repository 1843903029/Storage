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

        /// <summary>
        /// 计量单位分页
        /// </summary>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public ActionResult Jldws(int PageSize)
        {
            return Json(BLL.LLQ.JldwManager.GetCount(PageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetJldwAll(int PageIndex, int PageSize, Models.JLinfo jldw)
        {
            return Json(BLL.LLQ.JldwManager.Jldw(PageIndex, PageSize, jldw), JsonRequestBehavior.AllowGet);
        }
        

        public ActionResult Cplb()
        {
            return View();
        }


        /// <summary>
        /// 产品类别分页
        /// </summary>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public ActionResult Cplbs(int PageSize)
        {
            return Json(BLL.LLQ.CplbManager.GetCount(PageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCplbAll(int PageIndex, int PageSize, Models.CpLbinfo Cplb)
        {
            return Json(BLL.LLQ.CplbManager.lb(PageIndex, PageSize, Cplb), JsonRequestBehavior.AllowGet);
        }


        public ActionResult CpGl()
        {
            return View();
        }



    }
}