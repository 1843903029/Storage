﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.LLQ
{
    public class CplbManager
    {
        public static Models.PageList lbfenye(int pageIndex, int pageSize)
        {
            return DAL.LLQ.CplbService.lbfenye( pageIndex,  pageSize);
        }

        //新增
        public static int CplbAdd(Models.CpLbinfo cplb)
        {
            return DAL.LLQ.CplbService.CplbAdd(cplb);
        }

        //删除
        public static int CplbDet(int id)
        {
            return DAL.LLQ.CplbService.CplbDet(id);

        }


    }
}
