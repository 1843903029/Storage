﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.TXY
{
    public class SysDepartService
    {
        public static PageList SysDepartfenye(int pageIndex, int pageSize,SysDepart d)
        {
            StorageEntities entity = new StorageEntities();
            //实例化分页的类
            PageList list = new PageList();
            //var obj = from p in entity.Books orderby p.Id descending select p;
            //return obj.Take(10).ToList();
            //匿名类型
            var obj = from p in entity.SysDepart
                      orderby p.SysDepartID descending
                      select new
                      {
                          Admin = d.Admin,
                          CreateTime = d.CreateTime,
                          DepartName = d.DepartName,
                          DepartNum = d.DepartNum,
                          IsDelete = d.IsDelete,
                          SysDepartID =d.SysDepartID,
                          



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