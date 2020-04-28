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
        public static PageList Adminfenye(int pageIndex, int pageSize,int Stuate)
        {
            StorageEntities entity = new StorageEntities();
            //匿名类型
            var obj = from p in entity.Admin
                      where p.SysStatus.StatusID == Stuate &&
                      p.IsDelete == true
                      orderby p.AdminID ascending
                      select new
                      {
                          AdminID = p.AdminID,
                          UserName = p.UserName,
                          UserCode = p.UserCode,
                          RealName = p.RealName,
                          Email = p.Email,
                          Phone = p.Phone,
                          LoginCount = p.LoginCount,
                          //DepartNum_id = p.DepartNum_id,
                          //RoleNum = p.RoleNum,
                          IsDelete = p.IsDelete,
                          Stuate = p.SysStatus.StatusID,
                          DepartName = p.SysDepart.DepartName,
                          RoleName = p.SysRole.RoleName,

                         
                      };
            PageList list = new PageList();
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            list.PageCount = obj.Count();
            return list;
        }
        public static int GetRows()
        {
            StorageEntities entity = new StorageEntities();
            return entity.SysRole.Count();
        }
        //删除
        public static int SysAdmindelete(int AdminID)
        {
            StorageEntities entity = new StorageEntities();
            var obj = (from p in entity.Admin where p.AdminID == AdminID select p).First();
            obj.IsDelete = false;
            return entity.SaveChanges();

        }
        //新增
        public static int SysAdminadd(Admin admin)
        {
            StorageEntities h = new StorageEntities();
            h.Admin.Add(admin);
            return h.SaveChanges();
        }
        //下拉框绑定
        public static IQueryable SysAdminbyDepartNamebanding()
        {
            StorageEntities h = new StorageEntities();
            var obj = from p in h.SysDepart
                      select new
                      {
                          SysDepartID = p.SysDepartID,
                          DepartName = p.DepartName
                      };
            return obj;

        }
        //下拉框绑定
        public static IQueryable SysAdminbyRoleNamebanding()
        {
            StorageEntities h = new StorageEntities();
            var obj = from p in h.SysRole
                      select new
                      {
                          SysRoleID = p.SysRoleID,
                          RoleName = p.RoleName
                      };
            return obj;

        }
        //读取
        public static IQueryable AdminGetById(int AdminID)
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.Admin
                      where p.AdminID == AdminID
                      select new
                      {
                          UserName = p.UserName,
                          UserCode = p.UserCode,
                          PassWord = p.PassWord,
                          RealName = p.RealName,
                          Email = p.Email,
                          Phone = p.Phone,
                          DepartNum_id = p.DepartNum_id,
                          RoleNum = p.RoleNum,
            
                          
                      };
            return obj;
        }
        //修改
        public static int AdminEdit(Admin admin)
        {
            StorageEntities entity = new StorageEntities();
            var obj = (from p in entity.Admin where p.AdminID == admin.AdminID select p).First();
            obj.UserName = admin.UserName;
            obj.UserCode = admin.UserCode;
            obj.PassWord = admin.PassWord;
            obj.RealName = admin.RealName;
            obj.Email = admin.Email;
            obj.RoleNum = admin.RoleNum;
            obj.DepartNum_id = admin.DepartNum_id;
            return entity.SaveChanges();

        }
        //模糊查询
        public static IQueryable AdminQuery(int pageIndex, int pageSize, string UserName)
        {
            StorageEntities entity = new StorageEntities();

            var obj = from p in entity.Admin
                      where p.UserName.IndexOf(UserName) != -1
                      && p.IsDelete == true
                      orderby p.AdminID
                      select new
                      {
                          AdminID = p.AdminID,
                          UserName = p.UserName,
                          UserCode = p.UserCode,
                          RealName = p.RealName,
                          Email = p.Email,
                          Phone = p.Phone,
                          LoginCount = p.LoginCount,
                          //DepartNum_id = p.DepartNum_id,
                          //RoleNum = p.RoleNum,
                          IsDelete = p.IsDelete,
                          Stuate = p.SysStatus.StatusID,
                          DepartName = p.SysDepart.DepartName,
                          RoleName = p.SysRole.RoleName,
                      };

            PageList list = new PageList();
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            list.PageCount = obj.Count();
            return list.DataList;

        }
    }
}
