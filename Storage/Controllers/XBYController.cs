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

        /// <summary>
        /// 出库管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChukuGuanli()
        {
            return View();
        }

        /// <summary>
        /// 报损管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaoSunGuanli()
        {
            return View();
        }


        /// <summary>
        /// 移库管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult YiKuGuanli()
        {
            return View();
        }

        /// <summary>
        /// 盘点管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult PanDianGuanli()
        {
            return View();
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