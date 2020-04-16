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
    }
}
