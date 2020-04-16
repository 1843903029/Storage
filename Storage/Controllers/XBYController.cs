using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Storage.Controllers
{
    public class XBYController : Controller
    {
        // GET: XBY
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 入库管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RukuGuanli()
        {
            return View();
        }

        public ActionResult RuKuList(int PageSize, int PageIndex, int State)
        {
            return Json(BLL.XBY.StorageManager.RuKuList(PageSize, PageIndex, State), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 出库管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChukuGuanli()
        {
            return View();
        }

        public ActionResult ChuKuList(int PageIndex, int PageSize, int State)
        {
            return Json(BLL.XBY.StockRemovalManager.ChuKuList(PageIndex, PageSize, State), JsonRequestBehavior.AllowGet);
        }

        public ActionResult ChuKuXF1()
        {
            return View();
        }


        public ActionResult BaoSunList(int PageIndex, int PageSize, int State)
        {
            return Json(BLL.XBY.BreakageManager.BaoSunList(PageIndex, PageSize, State), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 报损管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaoSunGuanli()
        {
            return View();
        }

        public ActionResult YiKuList(int PageIndex, int PageSize, int State)
        {
            return Json(BLL.XBY.MovementManager.YiKuList(PageIndex, PageSize, State), JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// 移库管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult YiKuGuanli()
        {
            return View();
        }

        public ActionResult PanDianList(int PageIndex, int PageSize, int State)
        {
            return Json(BLL.XBY.CycleCountManager.PanDianList(PageIndex, PageSize, State), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 盘点管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult PanDianGuanli()
        {
            return View();
        }


        public ActionResult TuiHuoList(int PageIndex, int PageSize, int State)
        {
            return Json(BLL.XBY.ReturnsManager.TuiHuoList(PageIndex, PageSize, State), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 退货管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TuiHuoGuanli()
        {
            return View();
        }


    }
}