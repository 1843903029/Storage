using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Storage.Controllers
{
    public class TXYController : Controller
    {
        // GET: TXY
        public ActionResult SysAdmin()
        {
            return View();
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