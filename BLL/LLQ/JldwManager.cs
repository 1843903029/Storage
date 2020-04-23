﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.LLQ
{
   public  class JldwManager
    {
        /// <summary>
        /// 计量单位分页查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PageList Jldwfenye(int pageIndex, int pageSize)
        {
            return DAL.LLQ.JldwService.Jldwfenye(pageIndex, pageSize);
        }

        /// <summary>
        /// 计量单位新增
        /// </summary>
        /// <param name="jldw"></param>
        /// <returns></returns>
        public static int JldwAdd(Models.JLinfo jldw)
        {
            return DAL.LLQ.JldwService.JldwAdd(jldw);
        }

        //删除
        public static int JldwDet(Models.JLinfo jldw)
        {
            return DAL.LLQ.JldwService.JldwDet(jldw);
        }



    }
}
