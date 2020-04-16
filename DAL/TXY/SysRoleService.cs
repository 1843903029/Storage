﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace DAL.TXY
{
    public class SysRoleService
    {
        public static PageList SysRolefenye(int pageIndex, int pageSize,SysRole r)
        {
            StorageEntities entity = new StorageEntities();
            //实例化分页的类
            PageList list = new PageList();
            //var obj = from p in entity.Books orderby p.Id descending select p;
            //return obj.Take(10).ToList();
            //匿名类型
            var obj = from p in entity.SysRole
                      orderby p.SysRoleID descending
                      select new
                      {
                          Admin = r.Admin,
                          RoleNum = r.RoleNum,
                          CreateTime = r.CreateTime,
                          IsDelete = r.IsDelete,
                          Remark = r.Remark,
                          RoleName = r.RoleName,
                          SysRoleID = r.SysRoleID,
                          


                      };
            // return 
            //设置分页数据
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            //设置总页数
            int rows = entity.SysRole.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;

            return list;
        }
        public static int GetRows()
        {
            StorageEntities entity = new StorageEntities();
            return entity.SysRole.Count();
        }
    }
}
