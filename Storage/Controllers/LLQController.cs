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
        //删除
        public ActionResult JldwDet(int jlid)
        {
            return Json(BLL.LLQ.JldwManager.JldwDet(jlid), JsonRequestBehavior.AllowGet);
        }
        //模糊查询
        public ActionResult JldwGetByQuery(int pageIndex, int pageSize, string jlName)
        {
            return Json(BLL.LLQ.JldwManager.JldwGetByQuery( pageIndex,  pageSize,  jlName), JsonRequestBehavior.AllowGet);
        }
        //单个id查询
        public ActionResult JldwGetById(int Jlid)
        {
            return Json(BLL.LLQ.JldwManager.JldwGetById(Jlid), JsonRequestBehavior.AllowGet);
        }
        //修改
        public ActionResult JldwEdit(JLinfo jldw)
        {
            return Json(BLL.LLQ.JldwManager.JldwEdit(jldw), JsonRequestBehavior.AllowGet);
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
        //模糊查询
        public ActionResult CplbQuery(int pageIndex, int pageSize, string CpLbName)
        {
            return Json(BLL.LLQ.CplbManager.CplbQuery(pageIndex, pageSize, CpLbName), JsonRequestBehavior.AllowGet);
        }
        //单个id查询
        public ActionResult CplbGetById(int id)
        {
            return Json(BLL.LLQ.CplbManager.CplbGetById(id), JsonRequestBehavior.AllowGet);
        }
        //修改
        public ActionResult CplbEdit(CpLbinfo cplb)
        {
            return Json(BLL.LLQ.CplbManager.CplbEdit(cplb), JsonRequestBehavior.AllowGet);
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
        public ActionResult CpGlDet(int CpID)
        {
            return Json(BLL.LLQ.CpGlManager.CpGlDet(CpID), JsonRequestBehavior.AllowGet);
        }
        //模糊查询
        public ActionResult CpGlQuery(int pageIndex, int pageSize, string CpXsName)
        {
            return Json(BLL.LLQ.CpGlManager.CpGlQuery(pageIndex, pageSize, CpXsName), JsonRequestBehavior.AllowGet);
        }
        //单个id查询
        public ActionResult CpGlGetById(int CpID)
        {
            return Json(BLL.LLQ.CpGlManager.CpGlGetById(CpID), JsonRequestBehavior.AllowGet);
        }
        //修改
        public ActionResult CpGlEdit(CpGlinfo cpgl)
        {
            return Json(BLL.LLQ.CpGlManager.CpGlEdit(cpgl), JsonRequestBehavior.AllowGet);
        }
    }
}