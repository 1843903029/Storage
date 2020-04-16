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
       
        public static Models.PageList SysRolefenye(int pageIndex, int pageSize,SysRole r)
        {

            return DAL.TXY.SysRoleService.SysRolefenye(pageIndex, pageSize,r);
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
