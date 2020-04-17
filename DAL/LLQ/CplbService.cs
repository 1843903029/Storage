using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.LLQ
{
    public class CplbService
    {
        public static Models.PageList lbfenye(int pageIndex, int pageSize)
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.CpLbinfo
                      where p.Delit == true
                      orderby p.ID ascending
                      select new
                      {
                          ID = p.ID,
                          CpId = p.CpId,
                          CpLbName = p.CpLbName,
                          UserName = p.UserName,//管理员的名称
                          CpTime = p.CpTime,
                          remark = p.remark
                      };
            PageList list = new PageList();
            list.DataList = obj;
            list.PageCount = obj.Count();

            return list;
        }

        public static Models.PageList lb(int pageIndex, int pageSize, CpLbinfo Cplb)
        {
            StorageEntities b = new StorageEntities();
            var query = from p in b.CpLbinfo select p;
            Models.PageList li = new Models.PageList();
            var list = from p in query
                       orderby p.ID ascending
                       select new
                       {
                           ID = p.ID,
                           CpId = p.CpId,
                           CpLbName = p.CpLbName,
                           UserName = p.UserName,//管理员的名称
                           CpTime = p.CpTime,
                           remark = p.remark
                           
                       };
            li.DataList = list.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = query.Count();
            li.PageCount = rows;// % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return li;
        }
        public static int GetRows()
        {
            StorageEntities entity = new StorageEntities();
            return entity.CpLbinfo.Count();
        }

    }
}
