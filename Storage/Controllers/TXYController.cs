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


        //登录
        public ActionResult Rogin(Admin a)
        {
                return Json(BLL.TXY.AdminManager.Rogin(a), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Login()
        {
            return View();
        }




        //SysRolefenye
        public ActionResult SysRoleIndexs(int PageSize)
        {
            return Json(BLL.TXY.SysRoleManager.GetCount(PageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAllSysRole(int PageIndex, int PageSize,SysRole r)
        {

            return Json(BLL.TXY.SysRoleManager.SysRolefenye(PageIndex, PageSize,r), JsonRequestBehavior.AllowGet);
        }


        //SysDepartfenye
        public ActionResult SysDepartIndexs(int PageSize)
        {
            return Json(BLL.TXY.SysDepartManager.GetCount(PageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAllSysDepart(int PageIndex, int PageSize, SysDepart d)
        {

            return Json(BLL.TXY.SysDepartManager.SysDepartfenye(PageIndex, PageSize,d), JsonRequestBehavior.AllowGet);
        }



        //Adminfenye
        public ActionResult AdminIndexs(int PageSize)
        {
            return Json(BLL.TXY.AdminManager.GetCount(PageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAllAdmin(int PageIndex, int PageSize, Admin a)
        {

            return Json(BLL.TXY.AdminManager.Adminfenye(PageIndex, PageSize,a), JsonRequestBehavior.AllowGet);
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