using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.LLJ
{
   public class CanDanManager
    {
        public static Models.PageList SysRolefenye(int pageIndex, int pageSize)
        {

            return DAL.LLJ.CaiDanService.caidan(pageIndex, pageSize);
        }
        public static int caidandel(SysDepart cd)
        {
            return DAL.LLJ.CaiDanService.caidandel(cd);
        }
        public static int caidanadd(SysDepart cd)
        {
            return DAL.LLJ.CaiDanService.caidanadd(cd);
        }
    }
}

