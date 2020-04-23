using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.LLJ

{
   public class CaiDanService
    {
        public static PageList caidan(int pageIndex, int pageSize)
        {
            StorageEntities ent = new StorageEntities();
            var obj = from p in ent.SysDepart
                      where p.IsDelete == true
                      orderby p.SysDepartID ascending
                      select new
                      {
                          ID= p.SysDepartID,
                          DepartNum = p.DepartNum,
                          DepartName = p.DepartName,
                        //  ChildCount = p.ChildCount,
                        //  ParentNum = p.ParentNum,
                       //   Depth = p.Depth,
                          IsDelete=p.IsDelete,
                          CreateTime=p.CreateTime,

                      };
         

            PageList list = new PageList();
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            list.PageCount = obj.Count();
            return list;

           
        }
        //删除
        public static int caidandel(int SysDepartID)
        {
            StorageEntities entity = new StorageEntities();
            var aa = entity.SysDepart.Find(SysDepartID);
            aa.SysDepartID = SysDepartID;
            aa.IsDelete = false;
            //var obj = (from p in entity.SysDepart where p.SysDepartID == cd.SysDepartID select p).First();
            //obj.IsDelete = cd.IsDelete;
            return entity.SaveChanges();

        }
        //新增
        public static int caidanadd(SysDepart cd)
        {
            StorageEntities entity = new StorageEntities();
            entity.SysDepart.Add(cd);
            return entity.SaveChanges();
        }
    }
}

