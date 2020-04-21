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

    }
}
