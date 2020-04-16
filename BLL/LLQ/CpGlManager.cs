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
        public static int GetCount(int pageSize)
        {
            int rows = DAL.LLQ.CpGlService.GetRows();
            if (rows % pageSize == 0)
            {
                return rows / pageSize;
            }
            return rows / pageSize + 1;
        }
        public static Models.PageList CpGl(int pageIndex, int pageSize, CpGlinfo Cpgl)
        {
            return DAL.LLQ.CpGlService.CpGl(pageIndex, pageSize, Cpgl);
        }
    }
}
