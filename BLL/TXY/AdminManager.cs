﻿using System;
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
        public static IQueryable Rogin(Admin a)
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
        }
}
