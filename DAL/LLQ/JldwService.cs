using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.LLQ
{
    public class JldwService
    {
        /// <summary>
        /// 计量单位分页查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PageList Jldwfenye(int pageIndex, int pageSize)
        {
            StorageEntities b = new StorageEntities();
            var obj = from p in b.JLinfo
                      where p.Delit == true
                      orderby p.Jlid ascending
                      select new
                      {
                          Jlid = p.Jlid,
                          Jlbh = p.Jlbh,
                          JlName = p.JlName

                      };
            PageList list = new PageList();
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            list.PageCount = obj.Count();
            return list;
        }

        //新增
        public static int JldwAdd(Models.JLinfo jldw)
        {
            StorageEntities b = new StorageEntities();
            b.JLinfo.Add(jldw);
            return b.SaveChanges();
        }

        //删除
        public static int JldwDet(Models.JLinfo jldw)
        {
            StorageEntities entity = new StorageEntities();
            var obj = (from p in entity.JLinfo where p.Jlid == jldw.Jlid select p).First();
            obj.Delit = jldw.Delit;
            return entity.SaveChanges();

        }

        public static IQueryable JldwGetById(int Jlid)
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.JLinfo
                      where p.Jlid == Jlid && p.Delit == true
                      select new
                      {
                          Jlid = p.Jlid,
                          Jlbh = p.Jlbh,
                          JlName = p.JlName
                      };
            return obj;
        }



    }
}
