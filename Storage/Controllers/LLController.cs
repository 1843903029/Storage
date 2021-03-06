﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace Storage.Controllers
{
    public class LLController : Controller
    {
        // GET: LL
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GYSguanli()
        {
            return View();
        }
        public ActionResult KHguanli()
        {
            return View();
        }
        public ActionResult huishou() {
            return Json(BLL.LL.GYSguanliManager.huishou(),JsonRequestBehavior.AllowGet);
        }
        public ActionResult huanyuan(int id)
        {
            return Json(BLL.LL.GYSguanliManager.huanyuan(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GaojiService(int pageindex, int pagesize, int CangKu, int kwType, string kwName)
        {
            return Json(BLL.LL.KweiGuanliManager.GaojiService(pageindex, pagesize, CangKu, kwType, kwName), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Listfenye1(int pageindex,int pagesize)
        {
            return Json(BLL.LL.KweiGuanliManager.Listfenye(pageindex, pagesize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Listfenye2(int pageindex, int pagesize)
        {
            return Json(BLL.LL.GYSguanliManager.Listfenye(pageindex, pagesize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Listfenye3(int pageindex, int pagesize)
        {
            return Json(BLL.LL.KHguanliManager.Listfenye(pageindex, pagesize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult delKH(int id) {
            return Json(BLL.LL.KHguanliManager.del(id),JsonRequestBehavior.AllowGet);
        }
        public ActionResult delKW(int id)
        {
            return Json(BLL.LL.KweiGuanliManager.del(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult delGYS(int id)
        {
            return Json(BLL.LL.GYSguanliManager.del(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult KWAdd(LocationManagement lo)
        {
            lo.Shuju = true;
            lo.Isdefault = 2;
            return Json(BLL.LL.KweiGuanliManager.add(lo), JsonRequestBehavior.AllowGet);
        }
        public ActionResult selectType()
        {
            return Json(BLL.LL.KweiGuanliManager.selectType(),JsonRequestBehavior.AllowGet);
        }
        public ActionResult mohu(int pageindex, int pagesize, string GysName)
        {
            return Json(BLL.LL.GYSguanliManager.mohu(pageindex, pagesize, GysName), JsonRequestBehavior.AllowGet);
        }
        public ActionResult mohuKH(int pageindex, int pagesize, string KHname)
        {
            return Json(BLL.LL.KHguanliManager.mohuKH(pageindex, pagesize, KHname), JsonRequestBehavior.AllowGet);
        }
        public ActionResult selectCK()
        {
            return Json(BLL.LL.KweiGuanliManager.selectCK(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult KWEdit(LocationManagement lo)
        {
            lo.Shuju = true;
            lo.Isdefault = 2;
            return Json(BLL.LL.KweiGuanliManager.KwEdit(lo),JsonRequestBehavior.AllowGet);
        }
        public ActionResult KWGetByID(int kwID)
        {
            return Json(BLL.LL.KweiGuanliManager.KwGetById(kwID),JsonRequestBehavior.AllowGet);
        }
            public ActionResult KHAdd(Client c)
        {
            c.State = true;
            c.Time = "2020-03-09";

            return Json(BLL.LL.KHguanliManager.add(c), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GYSAdd(Supplier sup) {
            sup.GysType = "合作供应商";
            sup.State = true;
            return Json(BLL.LL.GYSguanliManager.add(sup),JsonRequestBehavior.AllowGet);
        }

        public ActionResult GYSGetById(int id)
        {
            return Json(BLL.LL.GYSguanliManager.GYSGetById(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GYSEdit(Supplier sup)
        {
            return Json(BLL.LL.GYSguanliManager.GYSEdit(sup), JsonRequestBehavior.AllowGet);
        }
        public ActionResult KhGetById(int ID)
        {
            return Json(BLL.LL.KHguanliManager.KhGetById(ID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult KhEdit(Client c)
        {
            return Json(BLL.LL.KHguanliManager.KhEdit(c), JsonRequestBehavior.AllowGet);
        }
    }
}