using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Storage.Controllers
{
    public class LLJController : Controller
    {
        // GET: LLJ
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Rogin(Admin a)
        {
            return Json(BLL.LLJ.admManger.Rogin(a), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Login()
        {
            return View();
        }




        //fenye
        public ActionResult Indexs(int PageSize)
        {
            return Json(BLL.LLJ.CdanManager.GetCount(PageSize), JsonRequestBehavior.AllowGet);
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