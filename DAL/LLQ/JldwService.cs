using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.LLQ
{
  public  class JldwService
    {
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
            list.DataList = obj;
            list.PageCount = obj.Count();

            return list;
        }


        public static Models.PageList Jldw(int pageIndex, int pageSize, JLinfo jldw)
        {
            StorageEntities b = new StorageEntities();
            var query = from p in b.JLinfo select p;
            Models.PageList li = new Models.PageList();
            var list = from p in query
                       orderby p.Jlid ascending
                       select new
                       {
                           Jlid = p.Jlid,
                           Jlbh = p.Jlbh,
                           JlName = p.JlName

                       };
            li.DataList = list.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = query.Count();
            li.PageCount = rows;// % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return li;
        }

        public static int GetRows()
        {
            StorageEntities entity = new StorageEntities();
            return entity.JLinfo.Count();
        }
    }
}
