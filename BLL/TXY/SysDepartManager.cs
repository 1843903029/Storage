using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.TXY
{
    public class SysDepartManager
    {
        public static PageList SysDepartfenye(int pageIndex, int pageSize, SysDepart d)
        {
            return DAL.TXY.SysDepartService.SysDepartfenye(pageIndex,pageSize,d);
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
