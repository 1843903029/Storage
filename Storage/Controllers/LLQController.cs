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
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public ActionResult GetJldwAll(int PageIndex, int PageSize)
        {
            return Json(BLL.LLQ.JldwManager.Jldwfenye(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }


        public ActionResult Cplb()
        {
            return View();
        }

        /// <summary>
        /// 产品类别分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public ActionResult GetCplbAll(int PageIndex, int PageSize)
        {
            return Json(BLL.LLQ.CplbManager.lbfenye(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }


        public ActionResult CpGl()
        {
            return View();
        }

        /// <summary>
        /// 产品管理分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public ActionResult GetCpGlAll(int PageIndex, int PageSize)
        {
            return Json(BLL.LLQ.CpGlManager.CpGlfenye(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
    }
}