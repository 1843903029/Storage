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
        public static Models.PageList fy(int pageIndex, int pageSize, SysRole role)
        {
            StorageEntities b = new StorageEntities();
            var query = from p in b.SysRole select p;
            Models.PageList li = new Models.PageList();
            var list = from p in query
                       orderby p.SysRoleID ascending
                       select new
                       {
                           Admin = p.Admin,
                           RoleNum = p.RoleNum,
                           CreateTime = p.CreateTime,
                           IsDelete = p.IsDelete,
                           Remark = p.Remark,
                           RoleName = p.RoleName,
                           SysRoleID = p.SysRoleID,
                       };
            li.DataList = list.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = query.Count();
            li.PageCount = rows;// % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return li;
        }
        public static int GetRows()
        {
            StorageEntities entity = new StorageEntities();
            return entity.SysRole.Count();
        }
    }
}
