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
                          CpID = p.CpID,
                          Cpbh = p.Cpbh,
                          CpXsName = p.CpXsName,
                          CpSx = p.CpSx,
                          CpXx = p.CpXx,
                          CpPrice = p.CpPrice,
                          CpShuLiang = p.CpShuLiang,
                          Specification = p.Specification,
                          UserName = p.Client.KhName,                   //客户 用户名
                          CpLbName = p.CpLbinfo.CpLbName,                //产品类别的名称
                          CkName = p.Cangku.CKName,                      //仓库的名称
                          KwName = p.LocationManagement.kwName,          //仓库库位的名称
                          JlName = p.JLinfo.JlName,           //计量单位的名称
                          State = p.State,                    //是否删除
                          remark = p.remark
                      };
            PageList list = new PageList();
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            list.PageCount = obj.Count();
            return list;
        }

        /// <summary>
        /// 产品管理新增
        /// </summary>
        /// <param name="cpgl"></param>
        /// <returns></returns>
        public static int CpGlAdd(Models.CpGlinfo cpgl)
        {
            StorageEntities b = new StorageEntities();
            b.CpGlinfo.Add(cpgl);
            return b.SaveChanges();
        }

        //删除
        public static int CpGlDet(Models.CpGlinfo cpgl)
        {
            StorageEntities entity = new StorageEntities();
            var obj = (from p in entity.CpGlinfo where p.CpID == cpgl.CpID select p).First();
            obj.State = cpgl.State;
            return entity.SaveChanges();

        }

    }
}
