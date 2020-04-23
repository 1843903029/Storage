using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace Storage.Controllers
{
    public class LLJController : Controller
    {
        // GET: LLJ
        public ActionResult Index()
        {
            return View();
        }
        //SysDepart

        public ActionResult GetAllSysRole(int PageIndex, int PageSize)
        {

            return Json(BLL.LLJ.CanDanManager.SysRolefenye(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult caidandel(SysDepart cd)
        {

            return Json(BLL.LLJ.CanDanManager.caidandel(cd), JsonRequestBehavior.AllowGet);
        }
        //新增
        public ActionResult caidanadd(SysDepart cd)
        {

            return Json(BLL.LLJ.CanDanManager.caidanadd(cd), JsonRequestBehavior.AllowGet);
        }


        public ActionResult SysDepart()
        {
            return View();
        }
      
    }
}