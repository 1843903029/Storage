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
        /// <param name="zhu"></param>
        /// <returns></returns>
        public static int ADDRuku(Storage zhu)
        {
            return DAL.XBY.StorageService.ADDRuku(zhu);
        }

        /// <summary>
        /// 添加入库详表
        /// </summary>
        /// <param name="xiang"></param>
        /// <returns></returns>
        public static int ADDRukuXiang(StorageDetailed xiang)
        {
            return DAL.XBY.StorageService.ADDRukuXiang(xiang);
        }

        /// <summary>
        /// 删除入库单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int ShanChuRuKu(string id)
        {
            return DAL.XBY.StorageService.ShanChuRuKu(id);
        }

        /// <summary>
        /// 审核入库单
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static int RuKuShenHe(string danhao, int state)
        {
            return DAL.XBY.StorageService.RuKuShenHe(danhao, state);
        }

        /// <summary>
        /// 通过审核后修改相应库存数量
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public static int RuKuSHHou(int cpid, int Count)
        {
            return DAL.XBY.StorageService.RuKuSHHou(cpid, Count);
        }

        /// <summary>
        /// 修改入库主表
        /// </summary>
        /// 
        /// <returns></returns>
        public static int RuKuXiuZhu(Storage p)
        {
            return DAL.XBY.StorageService.RuKuXiuZhu(p);
        }


            /// <summary>
            /// 修改操作查询详表数据并删除数据库记录
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public static int RuKuDel(string id)
        {
            return DAL.XBY.StorageService.RuKuDel(id);
        }
        }
}
