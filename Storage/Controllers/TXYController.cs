﻿using System;
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
            @Session["user"] = a;
            return Json(BLL.TXY.AdminManager.Rogin(a), JsonRequestBehavior.AllowGet);
           
        }
        public ActionResult Login()
        {
            return View();
        }




        //SysRolefenye
       
        public ActionResult GetAllSysRole(int PageIndex, int PageSize)
        {

            return Json(BLL.TXY.SysRoleManager.SysRolefenye(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
        //删除
        public ActionResult SysRoledelete(int SysRoleID)
        {

            return Json(BLL.TXY.SysRoleManager.SysRoledelete(SysRoleID), JsonRequestBehavior.AllowGet);
        }
        //新增
        public ActionResult SysRoleadd(SysRole role)
        {

            return Json(BLL.TXY.SysRoleManager.SysRoleadd(role), JsonRequestBehavior.AllowGet);
        }

        //修改
        public ActionResult SysRoleRead()
        {

            return View(); 
        }




        //SysDepartfenye

        public ActionResult GetAllSysDepart(int PageIndex, int PageSize)
        {

            return Json(BLL.TXY.SysDepartManager.SysDepartfenye(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
        //删除
        public ActionResult SysDepartdelete(int SysDepartID)
        {

            return Json(BLL.TXY.SysDepartManager.SysDepartdelete(SysDepartID), JsonRequestBehavior.AllowGet);
        }
        //新增
        public ActionResult SysDepartadd(SysDepart depart)
        {

            return Json(BLL.TXY.SysDepartManager.SysDepartadd(depart), JsonRequestBehavior.AllowGet);
        }






        //Adminfenye
        public ActionResult GetAllAdmin(int PageIndex, int PageSize,int Stuate)
        {

            return Json(BLL.TXY.AdminManager.Adminfenye(PageIndex, PageSize, Stuate), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Indexs(int PageSize)
        {
            return Json(BLL.TXY.AdminManager.GetCount(PageSize), JsonRequestBehavior.AllowGet);
        }
        //删除
        public ActionResult SysAdmindelete(int AdminID)
        {

            return Json(BLL.TXY.AdminManager.SysAdmindelete(AdminID), JsonRequestBehavior.AllowGet);
        }
        //新增
        public ActionResult SysAdminadd(Admin admin)
        {

            return Json(BLL.TXY.AdminManager.SysAdminadd(admin), JsonRequestBehavior.AllowGet);
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