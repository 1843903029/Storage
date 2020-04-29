using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.TXY
{
    public class AdminManager
    {
        //登录
        public static Admin Rogin(Admin a)
        {
            return DAL.TXY.AdminService.Rogin(a);
        }
        //fenye
        public static PageList Adminfenye(int pageIndex, int pageSize,int Stuate)
        {
            return DAL.TXY.AdminService.Adminfenye(pageIndex, pageSize, Stuate);
        }
        public static int GetCount(int pageSize)
        {
            int rows = DAL.TXY.AdminService.GetRows();
            if (rows % pageSize == 0)
            {
                return rows / pageSize;
            }
            return rows / pageSize + 1;
        }
        //删除
        public static int SysAdmindelete(int AdminID)
        {
            return DAL.TXY.AdminService.SysAdmindelete(AdminID);

        }
        //新增
        public static int SysAdminadd(Admin admin)
        {
            return DAL.TXY.AdminService.SysAdminadd(admin);
        }
        public static IQueryable SysAdminbyDepartNamebanding()
        {
            return DAL.TXY.AdminService.SysAdminbyDepartNamebanding();
        }
        public static IQueryable SysAdminbyRoleNamebanding()
        {
            return DAL.TXY.AdminService.SysAdminbyRoleNamebanding();
        }
        //读取
        public static IQueryable AdminGetById(int AdminID)
        {
            return DAL.TXY.AdminService.AdminGetById(AdminID);
        
    }
        //修改
        public static int AdminEdit(Admin admin)
        {
        return DAL.TXY.AdminService.AdminEdit(admin);

    }
        //模糊查询
        public static IQueryable AdminQuery(int pageIndex, int pageSize, string UserName)
        {

        return DAL.TXY.AdminService.AdminQuery(pageIndex, pageSize, UserName);
    }
        //高级查询
        public static PageList AdminQuerylist(int pageIndex, int pageSize, string UserName, string UserCode, int DepartName, int RoleName)
        {
            return DAL.TXY.AdminService.AdminQuerylist(pageIndex, pageSize, UserName, UserCode, DepartName, RoleName);
        }
        }
}
