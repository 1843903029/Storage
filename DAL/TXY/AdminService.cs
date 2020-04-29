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
        public static Admin Rogin(Admin a)
        {
            StorageEntities entity = new StorageEntities();
            
            var obj = from p in entity.Admin
                      where p.UserName == a.UserName && p.PassWord == a.PassWord
                      select p;
            if (obj.Count() > 0)
            {
                return obj.First();
            }
            else
            {
                return null;
            }
        }
        public static PageList Adminfenye(int pageIndex, int pageSize, int Stuate)
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
                          AdminID = p.AdminID,
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
            obj.AdminID = admin.AdminID;
            obj.UserName = admin.UserName;
            obj.UserCode = admin.UserCode;
            obj.PassWord = admin.PassWord;
            obj.RealName = admin.RealName;
            obj.Email = admin.Email;
            obj.RoleNum = admin.RoleNum;
            obj.PassWord = admin.PassWord;
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
        //高级查询
        public static PageList AdminQuerylist(int pageIndex, int pageSize, string UserName, string UserCode, string DepartName, string RoleName)
        {
            StorageEntities ent = new StorageEntities();
            PageList list = new PageList();
            var obj = from p in ent.Admin
                      where p.IsDelete == true
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
                          IsDelete = p.IsDelete,
                          Stuate = p.SysStatus.StatusID,
                          DepartName = p.SysDepart.DepartName,
                          RoleName = p.SysRole.RoleName,
                      };

            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = obj.Count();


            if (obj.Count() != 0 && !string.IsNullOrEmpty(UserName))
            {
                obj = obj.Where(p => p.UserName == UserName);
                list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
                rows = obj.Count();
                return list;
            }
            if (obj.Count() != 0 && !string.IsNullOrEmpty(UserCode))
            {
                obj = obj.Where(p => p.UserCode == UserCode);
                list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
                rows = obj.Count();
                return list;

            }
            if (obj.Count() != 0 && !string.IsNullOrEmpty(DepartName))
            {
                obj = obj.Where(p => p.DepartName == DepartName);
                list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
                rows = obj.Count();
                return list;

            }
            if (obj.Count() != 0 && !string.IsNullOrEmpty(RoleName))
            {
                obj = obj.Where(p => p.RoleName == RoleName);
                list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
                rows = obj.Count();
                return list;

            }
            return list;


        }
    }
}
