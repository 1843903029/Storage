using System;
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
       
        public static Models.PageList SysRolefenye(int pageIndex, int pageSize)
        {

            return DAL.TXY.SysRoleService.SysRolefenye(pageIndex, pageSize);
        }
        public static int SysRoledelete(SysRole role)
        {
            return DAL.TXY.SysRoleService.SysRoledelete(role);
        }
        }
}
