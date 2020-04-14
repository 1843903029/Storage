using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.LLQ
{
    public class CplbManager
    {
        public static int GetCount(int pageSize)
        {
            int rows = DAL.LLQ.CplbService.GetRows();
            if (rows % pageSize == 0)
            {
                return rows / pageSize;
            }
            return rows / pageSize + 1;
        }
        public static Models.PageList lb(int pageIndex, int pageSize, CpLbinfo Cplb)
        {
            return DAL.LLQ.CplbService.lb(pageIndex, pageSize, Cplb);
        }
    }
}
