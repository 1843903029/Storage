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
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            list.PageCount = obj.Count();
            return list;
        }
        //删除
        public static int SysDepartdelete(int SysDepartID)
        {
            StorageEntities entity = new StorageEntities();
            var obj = (from p in entity.SysDepart where p.SysDepartID == SysDepartID select p).First();
            obj.IsDelete = false;
            return entity.SaveChanges();

        }
        //新增
        public static int SysDepartadd(SysDepart depart)
        {
            StorageEntities h = new StorageEntities();
            h.SysDepart.Add(depart);
            return h.SaveChanges();
        }
        //修改
        public static int SysDepartEit(int SysDepartID, string DepartName)
        {
            StorageEntities entity = new StorageEntities();
            var obj = (from p in entity.SysDepart where p.SysDepartID == SysDepartID select p).First();
            obj.DepartName = DepartName;
            return entity.SaveChanges();

        }
    }
}
