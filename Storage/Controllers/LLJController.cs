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

        public ActionResult GetAllFunction(int PageIndex=1, int PageSize=2)
        {

            return Json(BLL.LLJ.CanDanManager.Functionfenye(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult caidandel(int NodeId)
        {

            return Json(BLL.LLJ.CanDanManager.caidandel(NodeId), JsonRequestBehavior.AllowGet);
        }
        //
        public ActionResult FunctionGetById(int NodeId)
        {

            return Json(BLL.LLJ.CanDanManager.FunctionGetById(NodeId), JsonRequestBehavior.AllowGet);
        }
        
        //新增
        public ActionResult caidanadd(Function cd)
        {
            cd.ADDTime = DateTime.Now;
            return Json(BLL.LLJ.CanDanManager.caidanadd(cd), JsonRequestBehavior.AllowGet);
        }
        //修改
        public ActionResult FunctionEdit(int NodeId, string DisplayName)
        {

            return Json(BLL.LLJ.CanDanManager.FunctionEdit( NodeId, DisplayName), JsonRequestBehavior.AllowGet);
        }
        //模糊查询
        public ActionResult FunctionQuery(int PageIndex, int PageSize, string DisplayName)
        {

            return Json(BLL.LLJ.CanDanManager.FunctionQuery(PageIndex, PageSize, DisplayName), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Function()
        {
            return View();
        }
      
    }
}