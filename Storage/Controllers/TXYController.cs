using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace Storage.Controllers
{
    public class TXYController : Controller
    {
        // GET: TXY
        public ActionResult SysAdmin()
        {
            return View();
        }
        public ActionResult Rgion(Admin a)
        {
                return Json(BLL.TXY.AdminManager.Rogin(a), JsonRequestBehavior.AllowGet);
        }
        //fenye
        public ActionResult Indexs(int PageSize)
        {
            return Json(BLL.TXY.SysRoleManager.GetCount(PageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAll(int PageIndex, int PageSize, Models.SysRole role)
        {

            return Json(BLL.TXY.SysRoleManager.fy(PageIndex, PageSize, role), JsonRequestBehavior.AllowGet);
        }
        public ActionResult SysRole()
        {
            return View();
        }
        public ActionResult SysDepart()
        {
            return View();
        }
    }
}