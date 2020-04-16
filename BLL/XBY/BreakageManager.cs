using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.XBY
{
    public class BreakageManager
    {
        /// <summary>
        /// 报损分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static PageList BaoSunList(int PageIndex, int PageSize, int State)
        {
            return DAL.XBY.BreakageService.BaoSunList(PageIndex, PageSize, State);
        }
    }
}
