using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.XBY
{
    public class StorageManager
    {
        /// <summary>
        /// 查询入库信息
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static PageList RuKuList(int PageSize, int PageIndex, int State)
        {
            return DAL.XBY.StorageService.RuKuList(PageSize, PageIndex, State);
        }

        /// <summary>
        /// 查询所有入库信息
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static PageList RuKuList(int PageSize, int PageIndex)
        {
            return DAL.XBY
                .StorageService.RuKuList(PageSize, PageIndex);
        }

        /// <summary>
        /// 模糊查询分页
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <returns></returns>
        public static PageList MoHuRuKuList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            return DAL.XBY.StorageService.MoHuRuKuList(PageSize, PageIndex, Danhao, time1, time2);
        }


        /// <summary>
        /// 通过单号查询入库信息
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static IQueryable RuKuList(string Danhao)
        {
            return DAL.XBY.StorageService.RuKuList(Danhao);
        }


            /// <summary>
            /// 添加入库单
            /// </summary>
            /// <param name="xiang"></param>
            /// <param name="zhu"></param>
            /// <returns></returns>
            public static int ADDRuku(Storage zhu,List<StorageDetailed> xiang)
        {
            return DAL.XBY.StorageService.ADDRuku(zhu, xiang);
        }
        }
}
