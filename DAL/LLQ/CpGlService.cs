using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.LLQ
{
    public class CpGlService
    {
        public static Models.PageList CpGlfenye(int pageIndex, int pageSize)
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.CpGlinfo
                      where p.State == true
                      orderby p.Cpbh ascending
                      select new
                      {
                          CkId = p.CkId,
                          Cpbh = p.Cpbh,
                          CpXsName = p.CpXsName,
                          CpSx = p.CpSx,
                          CpXx = p.CpXx,
                          CpPrice = p.CpPrice,
                          Specification = p.Specification,
                          CpLbName = p.CpLbinfo.CpLbName,      //产品类别的名称
                          CpJlName = p.JLinfo.JlName,           //计量单位的名称
                          remark = p.remark
                      };
            PageList list = new PageList();
            list.DataList = obj;
            list.PageCount = obj.Count();

            return list;
        }



        public static Models.PageList CpGl(int pageIndex, int pageSize, CpGlinfo Cpgl)
        {
            StorageEntities b = new StorageEntities();
            var query = from p in b.CpGlinfo select p;
            Models.PageList li = new Models.PageList();
            var list = from p in query
                       orderby p.CkId ascending
                       select new
                       {
                           CkId = p.CkId,
                           Cpbh = p.Cpbh,
                           CpXsName = p.CpXsName,
                           CpSx = p.CpSx,
                           CpXx = p.CpXx,
                           CpPrice = p.CpPrice,
                           Specification = p.Specification,
                           CpLbName = p.CpLbinfo.CpLbName,      //产品类别的名称
                           CpJlName = p.JLinfo.JlName,           //计量单位的名称
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
            return entity.JLinfo.Count();
        }
    }
}
