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
            PageList list = new PageList();
            list.DataList = obj;
            list.PageCount = obj.Count();

            //list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            ////设置总页数
            //int rows = ent.SysRole.Count();
            //list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;

            return list;
        }
    }
}
