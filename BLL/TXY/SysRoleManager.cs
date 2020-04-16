﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.TXY
{
   public class SysRoleManager
    {
       
        public static Models.PageList fenye(int pageIndex, int pageSize)
        {

            return DAL.TXY.SysRoleService.fenye(pageIndex, pageSize);
        }
        public static int GetCount(int pageSize)
        {
            int rows = DAL.TXY.SysRoleService.GetRows();
            if (rows % pageSize == 0)
            {
                return rows / pageSize;
            }
            return rows / pageSize + 1;
        }
    }
}
