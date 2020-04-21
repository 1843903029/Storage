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
                          CpID= p.CpID,
                          Cpbh = p.Cpbh,
                          CpXsName = p.CpXsName,
                          CpSx = p.CpSx,
                          CpXx = p.CpXx,
                          CpPrice = p.CpPrice,
                          CpShuLiang = p.CpShuLiang,
                          Specification = p.Specification,      
                          UserId = p.UserId,                    //客户 用户名
                          CpLbName = p.CpLbinfo.CpLbName,      //产品类别的名称
                          CkId=p.CkId,                      //仓库的id
                          KwId=p.KwId,                      //仓库库位的名称
                          JlName = p.JLinfo.JlName,           //计量单位的名称
                          State=p.State,                    //是否删除
                          remark = p.remark
                      };
            PageList list = new PageList();
            list.DataList = obj;
            list.PageCount = obj.Count();

            return list;
        }

        //public static int CpGlAdd(Models.CpGlinfo cpgl)
        //{

        //}












    }
}
