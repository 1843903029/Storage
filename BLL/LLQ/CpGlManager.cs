using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.LLQ
{
    public class CpGlManager
    {
        public static Models.PageList CpGlfenye(int pageIndex, int pageSize)
        {
            return DAL.LLQ.CpGlService.CpGlfenye(pageIndex, pageSize);
        }

        public static int CpGlAdd(Models.CpGlinfo cpgl)
        {
            return DAL.LLQ.CpGlService.CpGlAdd(cpgl);
        }

        //删除
        public static int CpGlDet(Models.CpGlinfo cpgl)
        {
            return DAL.LLQ.CpGlService.CpGlDet(cpgl);
        }

    }
}
