using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.TXY
{
    public class SysDepartService
    {
        public static PageList SysDepartfenye(int pageIndex, int pageSize)
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.SysDepart
                      where p.IsDelete==true
                      orderby p.SysDepartID ascending
                      select new
                      {
                          CreateTime = p.CreateTime,
                          DepartName = p.DepartName,
                          DepartNum = p.DepartNum,
                          IsDelete = p.IsDelete,
                          SysDepartID =p.SysDepartID,
                      };
            PageList list = new PageList();
            list.DataList = obj;
            list.PageCount = obj.Count();

            return list;
        }
    }
}
