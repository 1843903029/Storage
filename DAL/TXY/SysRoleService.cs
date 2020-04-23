using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace DAL.TXY
{
    public class SysRoleService
    {
        public static PageList SysRolefenye(int pageIndex, int pageSize)
        {
            StorageEntities ent = new StorageEntities();
            var obj = from p in ent.SysRole
                      where p.IsDelete == true
                      orderby p.SysRoleID ascending
                      select new
                      {
                          SysRoleID=p.SysRoleID,
                          IsDelete=p.IsDelete,
                          Remark=p.Remark,
                          RoleName=p.RoleName,
                          RoleNum=p.RoleNum,
                          CreateTime=p.CreateTime,
                          

                      };
            //PageList list = new PageList();
            //list.DataList = obj;
            //list.PageCount = obj.Count();

            //list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            ////设置总页数
            //int rows = ent.SysRole.Count();
            //list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            PageList list = new PageList();
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            list.PageCount = obj.Count();
            return list;
        }
        //删除
        public static int SysRoledelete(int SysRoleID)
        {
            StorageEntities entity = new StorageEntities();
            var obj = (from p in entity.SysRole where p.SysRoleID ==SysRoleID select p).First();
            obj.IsDelete =false;
            return entity.SaveChanges();

        }
        //新增
        public static int SysRoleadd(SysRole role)
        {
            StorageEntities h = new StorageEntities();
            h.SysRole.Add(role);
            return h.SaveChanges();
        }
        //public static int SysRoleadd(SysRole role)
        //{
        //    StorageEntities entity = new StorageEntities();
        //    entity.SysRole.Add(role);
        //    return entity.SaveChanges();
        //}
        public static IQueryable SysRoleGetById(int SysRoleID)
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.SysRole
                      where p.SysRoleID == SysRoleID&&p.IsDelete==true
                      select new
                      {
                          SysRoleID = p.SysRoleID,
                          IsDelete = p.IsDelete,
                          RoleName = p.RoleName,
                          RoleNum = p.RoleNum,
                      };
            return obj;
        }

        public static int SysRoleEdit(SysRole role)
        {
            StorageEntities entity = new StorageEntities();
            var obj = (from p in entity.SysRole where p.SysRoleID == role.SysRoleID select p).First();
            obj.RoleNum = role.RoleNum;
            obj.RoleName = role.RoleName;
            obj.Remark = role.Remark;

            return entity.SaveChanges();

        }
    }
}
