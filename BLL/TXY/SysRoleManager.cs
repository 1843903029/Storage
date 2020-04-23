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
        public static int SysRoledelete(int SysRoleID)
        {
            return DAL.TXY.SysRoleService.SysRoledelete(SysRoleID);
        }
        public static int SysRoleadd(SysRole role)
        {
            return DAL.TXY.SysRoleService.SysRoleadd(role);
        }
        public static IQueryable SysRoleGetById(int SysRoleID)
        {
            return DAL.TXY.SysRoleService.SysRoleGetById(SysRoleID);
        }

        public static int SysRoleEdit(SysRole role)
        {
            return DAL.TXY.SysRoleService.SysRoleEdit(role);

        }
    }
}
