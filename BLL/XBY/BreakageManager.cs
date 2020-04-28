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

        /// <summary>
        /// 所有报损分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList BaoSunList(int PageIndex, int PageSize)
        {
            return DAL.XBY.BreakageService.SuoYouBaoSunList(PageIndex, PageSize);
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
        public static PageList MoHuBaoSunList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            return DAL.XBY.BreakageService.MoHuBaoSunList(PageSize, PageIndex, Danhao, time1, time2);
        }

        /// <summary>
        /// 通过单号查询报损信息
        /// </summary>
        /// <returns></returns>
        public static IQueryable Baoxuncha(string Danhao)
        {
            return DAL.XBY.BreakageService.Baoxuncha(Danhao);
        }

        /// <summary>
        /// 删除报损单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int ShanChuBaoSun(string id)
        {
            return DAL.XBY.BreakageService.ShanChuBaoSun(id);
        }

        /// <summary>
        /// 新增报损主表
        /// </summary>
        /// <param name="chuku"></param>
        /// <returns></returns>
        public static int AddBaoSun(Breakage zhu)
        {
            return DAL.XBY.BreakageService.AddBaoSun(zhu);
        }

        /// <summary>
        /// 新增报损详表
        /// </summary>
        /// <param name="chuku"></param>
        /// <returns></returns>
        public static int AddBaoSuniang(BreakageDetailed xiang)
        {
            return DAL.XBY.BreakageService.AddBaoSuniang(xiang);
        }

        /// <summary>
        /// 审核报损单
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static int BaoSunShenHe(string danhao, int state)
        {
            return DAL.XBY.BreakageService.BaoSunShenHe(danhao, state);
        }

        /// <summary>
        /// 通过审核后修改相应库存数量
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public static int BaoSunSHHou(int cpid, int Count)
        {
            return DAL.XBY.BreakageService.BaoSunSHHou(cpid, Count);
        }

        }
}
