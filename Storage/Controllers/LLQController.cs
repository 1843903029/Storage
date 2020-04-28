﻿using System;
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
        /// <summary>
        /// 计量单位的页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Jldw()
        {
            return View();
        }
       
        /// <summary>
        /// 产品类别的页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Cplb()
        {
            return View();
        }
        
        /// <summary>
        /// 产品管理的页面
        /// </summary>
        /// <returns></returns>
        public ActionResult CpGl()
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
        /// <summary>
        /// 计量单位添加
        /// </summary>
        /// <param name="jldw"></param>
        /// <returns></returns>
        public ActionResult JldwAdd(JLinfo jldw)
        {
            jldw.Delit = true;
            return Json(BLL.LLQ.JldwManager.JldwAdd(jldw),JsonRequestBehavior.AllowGet);
        }

        public ActionResult JldwDet(int jlid)
        {
            return Json(BLL.LLQ.JldwManager.JldwDet(jlid), JsonRequestBehavior.AllowGet);
        }

        public ActionResult JldwGetById(int Jlid)
        {
            return Json(BLL.LLQ.JldwManager.JldwGetById(Jlid), JsonRequestBehavior.AllowGet);
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
        //新增
        public ActionResult CplbAdd(CpLbinfo cplb)
        {
            cplb.Delit = true;
            cplb.UserName = 1;
            cplb.CpTime= DateTime.Now;
            return Json(BLL.LLQ.CplbManager.CplbAdd(cplb), JsonRequestBehavior.AllowGet);
        }
        //删除
        public ActionResult CplbDet(int id)
        {
            return Json(BLL.LLQ.CplbManager.CplbDet(id), JsonRequestBehavior.AllowGet);
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
        //新增
        public ActionResult CpGlAdd(CpGlinfo cpgl)
        {
            cpgl.State = true;
            return Json(BLL.LLQ.CpGlManager.CpGlAdd(cpgl), JsonRequestBehavior.AllowGet);
        }
        //删除
        public ActionResult CpGlDet(CpGlinfo cpgl )
        {
            cpgl.State = false;
            return Json(BLL.LLQ.CpGlManager.CpGlDet(cpgl), JsonRequestBehavior.AllowGet);
        }

    }
}