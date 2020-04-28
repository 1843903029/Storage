using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.XBY
{
    public class StockRemovalManager
    {
        /// <summary>
        /// 出库分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static PageList ChuKuList(int PageIndex, int PageSize, int State)
        {
            return DAL.XBY.StockRemovalService.ChuKuList(PageIndex, PageSize, State);
        }

        /// <summary>
        /// 所有出库分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList ChuKuList(int PageIndex, int PageSize)
        {
            return DAL.XBY.StockRemovalService.ChuKuList(PageIndex, PageSize);
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
        public static PageList MoHuChuKuList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            return DAL.XBY.StockRemovalService.MoHuChuKuList(PageSize, PageIndex, Danhao, time1, time2);
        }

        /// <summary>
        /// 通过单号查询入库信息
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static IQueryable ChuKuList(string Danhao)
        {
            return DAL.XBY.StockRemovalService.ChuKuList(Danhao);
        }

        /// <summary>
        /// 查找客户地址
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IQueryable chadizhi(int id)
        {
            return DAL.XBY.StockRemovalService.chadizhi(id);
        }
        /// <summary>
        /// 删除出库单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int ShanChuChuKu(string id)
        {
            return DAL.XBY.StockRemovalService.ShanChuChuKu(id);
        }

        /// <summary>
        /// 新增出库主表
        /// </summary>
        /// <param name="chuku"></param>
        /// <returns></returns>
        public static int AddChuKu(StockRemoval zhu)
        {
            return DAL.XBY.StockRemovalService.AddChuKu(zhu);
        }

        /// <summary>
        /// 新增出库详表
        /// </summary>
        /// <param name="chuku"></param>
        /// <returns></returns>
        public static int AddChuKuXiang(StockRemovalDetailed xiang)
        {
            return DAL.XBY.StockRemovalService.AddChuKuXiang(xiang);
        }

        /// <summary>
        /// 审核出库单
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static int ChuKuShenHe(string danhao, int state)
        {
            return DAL.XBY.StockRemovalService.ChuKuShenHe(danhao, state);
        }

        /// <summary>
        /// 通过审核后修改相应库存数量
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public static int ChuKuSHHou(int cpid, int Count)
        {
            return DAL.XBY.StockRemovalService.ChuKuSHHou(cpid, Count);
        }

    }
}
