using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.TXY
{
   public class AdminService
    {
        //登录
        public static IQueryable Rogin(Admin a)
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.Admin
                      where p.UserName == a.UserName && p.PassWord == a.PassWord
                      select new {
                          AdminID= a.AdminID,
                          Authority = a.Authority,
                          Breakage = a.Breakage,
                          CpLbinfo = a.CpLbinfo,
                          CreateIp = a.CreateIp,
                          CreateTime = a.CreateTime,
                          CreateUser = a.CreateUser,
                          CycleCount = a.CycleCount,
                          DepartNum_id = a.DepartNum_id,
                          Email = a.Email,
                          IsDelete = a.IsDelete,
                          LoginCount = a.LoginCount,
                          Movement = a.Movement,
                          PassWord = a.PassWord,
                          Phone = a.Phone,
                          Picture = a.Picture,
                          RealName = a.RealName,
                          Remark = a.Remark,
                          Returns = a.Returns,
                          RoleNum = a.RoleNum,
                          Status_id = a.Status_id,
                          StockRemoval = a.StockRemoval,
                          Storage = a.Storage,
                          SysDepart = a.SysDepart,
                          SysRole = a.SysRole,
                          SysStatus = a.SysStatus,
                          UpdateTime = a.UpdateTime,
                          UserCode = a.UserCode,
                          UserName = a.UserName,
                         
                      };
            return obj;
        }
        public static PageList Adminfenye(int pageIndex, int pageSize,Admin a)
        {
            StorageEntities entity = new StorageEntities();
            //实例化分页的类
            PageList list = new PageList();
            //var obj = from p in entity.Books orderby p.Id descending select p;
            //return obj.Take(10).ToList();
            //匿名类型
            var obj = from p in entity.Admin
                      orderby p.AdminID descending
                      select new
                      {
                          AdminID = a.AdminID,
                          Authority = a.Authority,
                          Breakage = a.Breakage,
                          CpLbinfo = a.CpLbinfo,
                          CreateIp = a.CreateIp,
                          CreateTime = a.CreateTime,
                          CreateUser = a.CreateUser,
                          CycleCount = a.CycleCount,
                          DepartNum_id = a.DepartNum_id,
                          Email = a.Email,
                          IsDelete = a.IsDelete,
                          LoginCount = a.LoginCount,
                          Movement = a.Movement,
                          PassWord = a.PassWord,
                          Phone = a.Phone,
                          Picture = a.Picture,
                          RealName = a.RealName,
                          Remark = a.Remark,
                          Returns = a.Returns,
                          RoleNum = a.RoleNum,
                          Status_id = a.Status_id,
                          StockRemoval = a.StockRemoval,
                          Storage = a.Storage,
                          SysDepart = a.SysDepart,
                          SysRole = a.SysRole,
                          SysStatus = a.SysStatus,
                          UpdateTime = a.UpdateTime,
                          UserCode = a.UserCode,
                          UserName = a.UserName,
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
