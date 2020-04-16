using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.XBY
{
    public class ReturnsManager
    {
        /// <summary>
        /// 退货分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static PageList TuiHuoList(int PageIndex, int PageSize, int State)
        {
            return DAL.XBY.ReturnsService.TuiHuoList(PageIndex, PageSize, State);
        }
        }
}
