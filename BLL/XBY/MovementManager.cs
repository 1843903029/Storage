﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.XBY
{
    public class MovementManager
    {
        /// <summary>
        /// 移库分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static PageList YiKuList(int PageIndex, int PageSize, int State)
        {
            return DAL.XBY.MovementService.YiKuList(PageIndex, PageSize, State);
        }

        /// <summary>
        /// 所有移库分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList YiKuList(int PageIndex, int PageSize)
        {
            return DAL.XBY.MovementService.YiKuList(PageIndex, PageSize);
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
        public static PageList MoHuYiKuList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            return DAL.XBY.MovementService.MoHuYiKuList(PageSize, PageIndex, Danhao, time1, time2);
        }

       
        }
}
