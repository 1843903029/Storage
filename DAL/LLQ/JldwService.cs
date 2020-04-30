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
                      where p.Delit==true
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
        public static int JldwDet(int jlid)
        {
            StorageEntities entity = new StorageEntities();
            var obj = (from p in entity.JLinfo where p.Jlid == jlid select p).First();
            obj.Delit = false;
            return entity.SaveChanges();

        }

        //模糊查询名称
        public static IQueryable JldwGetByQuery(int pageIndex,int pageSize, string jlName)
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.JLinfo
                      where p.JlName.IndexOf(jlName)!=-1&&p.Delit==true
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
            return list.DataList;
        }

        //根据id查询单个
        public static IQueryable JldwGetById(int Jlid)
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.JLinfo
                      where p.Jlid == Jlid
                      orderby p.Jlid ascending
                      select new
                      {
                          Jlid = p.Jlid,
                          Jlbh = p.Jlbh,
                          JlName = p.JlName
                      };
            return obj;
        }
        //修改
        public static int JldwEdit(JLinfo jldw)
        {
            StorageEntities entity = new StorageEntities();
            var obj = (from p in entity.JLinfo where p.Jlid == jldw.Jlid select p).First();
            obj.Jlid = jldw.Jlid;
            obj.JlName = jldw.JlName;
            return entity.SaveChanges();

        }
        //查询计量单位
        public static IQueryable selectJldw()
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.JLinfo
                      select new
                      {
                          Jlid = p.Jlid,
                          JlName = p.JlName
                      };
            return obj;

        }


    }
}
