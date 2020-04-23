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

        public ActionResult GetAllSysRole(int PageIndex=1, int PageSize=2)
        {

            return Json(BLL.LLJ.CanDanManager.SysRolefenye(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult caidandel(int SysDepartID)
        {

            return Json(BLL.LLJ.CanDanManager.caidandel(SysDepartID), JsonRequestBehavior.AllowGet);
        }
        //新增
        public ActionResult caidanadd(SysDepart cd)
        {
            cd.CreateTime = DateTime.Now;
            return Json(BLL.LLJ.CanDanManager.caidanadd(cd), JsonRequestBehavior.AllowGet);
        }


        public ActionResult SysDepart()
        {
            return View();
        }
      
    }
}