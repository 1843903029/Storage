using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.XBY
{
   public class CycleCountManager
    {
        /// <summary>
        /// 盘点分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static PageList PanDianList(int PageIndex, int PageSize, int State)
        {
            return DAL.XBY.CycleCountService.PanDianList(PageIndex, PageSize, State);
        }
        }
}
