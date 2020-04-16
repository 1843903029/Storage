using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.LLQ
{
   public class JldwManager
    {
        public static int GetCount(int pageSize)
        {
            int rows = DAL.LLQ.JldwService.GetRows();
            if (rows % pageSize == 0)
            {
                return rows / pageSize;
            }
            return rows / pageSize + 1;
        }
        public static Models.PageList Jldw(int pageIndex, int pageSize, JLinfo Jldw)
        {
            return DAL.LLQ.JldwService.Jldw(pageIndex, pageSize, Jldw);
        }
    }
}
