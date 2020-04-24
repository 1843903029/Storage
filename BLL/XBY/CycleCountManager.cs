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

        /// <summary>
        /// 盘点分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList PanDianList(int PageIndex, int PageSize)
        {
            return DAL.XBY.CycleCountService.PanDianList(PageIndex, PageSize);
        }

        /// <summary>
        /// 模糊查询分页
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="Danhao"></param>
        /// <param name="time1"></param>
        /// <param name="time2"></param>
        /// <returns></returns>
        public static PageList MoHuPanDianList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            return DAL.XBY.CycleCountService.MoHuPanDianList(PageSize, PageIndex, Danhao, time1, time2);
        }

        /// <summary>
        /// 删除盘点单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int ShanChuPanDian(string id)
        {
            return DAL.XBY.CycleCountService.ShanChuPanDian(id);
        }
        }
}
